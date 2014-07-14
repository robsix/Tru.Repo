﻿IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'Tru' AND TABLE_NAME = 'Repo'))
	SELECT -1
ELSE IF (NOT EXISTS (SELECT * FROM Tru.Repo WHERE RepoName = @RepoName))
	SELECT -1
ELSE
	SELECT MAX(PatchVersion) FROM [Tru].[Repo] WHERE RepoName = @RepoName