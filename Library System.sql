USE [master]
BACKUP LOG [Library System] TO  DISK = N'C:\Users\Exper\Library System_LogBackup_2015-04-21_22-23-33.bak' WITH NOFORMAT, NOINIT,  NAME = N'Library System_LogBackup_2015-04-21_22-23-33', NOSKIP, NOREWIND, NOUNLOAD,  NORECOVERY ,  STATS = 5
RESTORE DATABASE [Library System] FROM  DISK = N'C:\Users\Exper\\Library System.bak' WITH  FILE = 1,  NOUNLOAD,  STATS = 5

GO

