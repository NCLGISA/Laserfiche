# Briefcase Extract

| Developer|Language|
| -------------|:----:
| Matthew Saunders|SQL Stored Procedure|

We use Laserfiche forms for our internal forms. This is a SQL Stored Procedure that our DBA(Matthew Saunders) Wrote for finding and notifying the development about Suspended Forms. What this Stored Procedure does is this.

1. Runs twice everyday M-F at 8:00AM and 1:00PM
2. Searches LF SQL for Suspended Forms
3. Any Suspended Forms it finds, it Emails us
4. If it does NOT find any Suspended Forms, it does not send an Emails