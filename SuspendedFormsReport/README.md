# Suspended Forms Report Stored Procedure

| Developer|Language|
| -------------|:----:
| Matthew Saunders|SQL Stored Procedure|

We use Laserfiche forms for our internal forms. This is a SQL Stored Procedure that our DBA(Matthew Saunders) Wrote for finding and notifying the development team about Suspended Forms. What this Stored Procedure does is this.

1. Runs twice everyday M-F at 8:00AM and 1:00PM
2. Searches LF Database for Suspended Forms
3. Any Suspended Forms it finds, it Emails us
4. If it does NOT find any Suspended Forms, it does not send an Emails

This Stored Procedure has helped us tremendously in keeping our help desk tickets down and our Laserfiche forms in better circulation. It allows us to catch the suspended forms before the department does.
