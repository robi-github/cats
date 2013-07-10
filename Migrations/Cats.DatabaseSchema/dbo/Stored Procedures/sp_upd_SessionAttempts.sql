﻿

CREATE PROCEDURE [sp_upd_SessionAttempts] (
  @SessionAttemptID int,
  @UserProfileID int,
  @RoleID int,
  @LoginDate datetime,
  @UserName varchar(50),
  @Password varchar(50),
  @WorkstationName varchar(50),
  @IPAddress varchar(50),
  @ApplicationName varchar(50)
)
AS
  UPDATE [dbo].[SessionAttempts] SET
    [UserProfileID] = @UserProfileID,
    [RoleID] = @RoleID,
    [LoginDate] = @LoginDate,
    [UserName] = @UserName,
    [Password] = @Password,
    [WorkstationName] = @WorkstationName,
    [IPAddress] = @IPAddress,
    [ApplicationName] = @ApplicationName
  WHERE 
    ([SessionAttemptID] = @SessionAttemptID)