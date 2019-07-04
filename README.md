# MVC_WithSecondIssue
<h2><b>Notice: </b></h2>
<p>
With changing "identity:false" to "identity:false" issue, a better way to solve it is to "re-create" the tables. 
Because _MigrationHistory Table records all the modifications we made from migration, so we cannot change previous setting 
(especially our initialModel) later by using migrations. 
So we need to clear _MigrationHistory, and this is how code-first entity framework works. 
</p>
<p>
Furthermore, we can also use Package Manager Console to go back to previous Migration version. There are two ways to do that.</br>
First, using a new database.</br>
&nbsp;&nbsp;&nbsp;&nbsp;1. Checkout the older version.</br>
&nbsp;&nbsp;&nbsp;&nbsp;2. Change the db name in the connection string.</br>
&nbsp;&nbsp;&nbsp;&nbsp;3. Update-database.</br>
Second, using an existing database.</br>
&nbsp;&nbsp;&nbsp;&nbsp;Using pm command with a switch:<b> update-database -TargetMigration: Target-migration-name </b>
</p>
