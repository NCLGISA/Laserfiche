USE [YourDatabase]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[sp_SuspendedForms]

@mailRecipients VARCHAR(255),
@mailProfile VARCHAR(50)

AS



IF
	(
	SELECT
		COUNT(DISTINCT WORKER.bp_instance_id) AS id
	FROM
		[dbo].[cf_bp_worker_instances] WORKER 
		JOIN [dbo].[cf_bp_main_instances] MAIN ON WORKER.bp_instance_id = MAIN.bp_instance_id 
	WHERE
		WORKER.[status] >= 9
		AND MAIN.[status] = 1
	) > 0

BEGIN


DECLARE @tableHTML NVARCHAR(MAX);



SET @tableHTML=
	N'Suspended Laserfiche Forms <br />' +
	N'<H1>Suspended List</H1>' +  
	N'<table border="1">' +  
	N'<tr><th>RowNum</th><th>bp_name</th><th>title</th><th>MainSatusCode</th><th>MainStatus</th><th>WorkerStatusCode</th><th>WorkerStatus</th><th>start_date</th><th>update_date</th>' +  
	CAST ( ( SELECT
				td = ROW_NUMBER() OVER(ORDER BY MAIN.[start_date] DESC)
			   ,''
			   ,td = MAIN.bp_name
			   ,''
			   ,td = MAIN.title
			   ,''
			   ,td = MAIN.[status]
			   ,''
			   ,td =
			    (CASE
				 WHEN MAIN.[status] = 1 THEN 'Running'
				 WHEN MAIN.[status] = 2 THEN 'Complete'
				 WHEN MAIN.[status] = 3 THEN 'Cancelled'
				 WHEN MAIN.[status] = 4 THEN 'Terminated by Error'
				 WHEN MAIN.[status] = 5 THEN 'Terminated by End Event'
				 ELSE CONVERT(VARCHAR(25),MAIN.[status])
				 END)
			  ,''
			  ,td = WORKER.[status]
			  ,''
			  ,td =
			   (CASE
				WHEN WORKER.[status] = 9 THEN 'Terminate'
				WHEN WORKER.[status] = 10 THEN 'Interrupted'
				WHEN WORKER.[status] = 11 THEN 'Suspended - Error'
				WHEN WORKER.[status] = 13 THEN 'Suspended - Task Error'
				ELSE CONVERT(VARCHAR(25),WORKER.[status])
			    END)
			  ,''
			  ,td = MAIN.[start_date]
			  ,''
			  ,td = WORKER.[update_date]
			FROM
			   [dbo].[cf_bp_worker_instances] WORKER 
			   JOIN [dbo].[cf_bp_main_instances] MAIN ON WORKER.bp_instance_id = MAIN.bp_instance_id 
			WHERE
			   WORKER.[status] >= 9
			   AND MAIN.[status] = 1
			   FOR XML PATH('tr'), TYPE   
	) AS NVARCHAR(MAX) ) +  
	N'</table>' ;


EXEC msdb.dbo.sp_send_dbmail
	@profile_name = @mailProfile,
	@recipients= @mailRecipients, 
    @subject = 'Alert - Suspended Laserfiche Forms',  
    @body = @tableHTML,  
    @body_format = 'HTML',
	@reply_to = 'noreply@yourdomain.com';

END






GO


