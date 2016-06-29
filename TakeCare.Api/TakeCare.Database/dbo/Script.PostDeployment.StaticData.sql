/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
TRUNCATE TABLE [Devices]

INSERT INTO [Devices] (MacAddress,[Description]) VALUES ('C8:0F:10:38:E6:D5', 'Khizer')
INSERT INTO [Devices] (MacAddress,[Description]) VALUES ('', 'Irina')