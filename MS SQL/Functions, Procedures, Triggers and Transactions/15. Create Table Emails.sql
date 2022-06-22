CREATE TRIGGER tr_LogEmail
ON Logs
FOR INSERT
AS
DECLARE @accountId INT = (SELECT TOP(1) AccountId FROM inserted)
DECLARE @oldSum DECIMAL(15, 2) = (SELECT TOP(1) OldSum FROM inserted)
DECLARE @newSum DECIMAL(15, 2) = (SELECT TOP(1) NewSum FROM inserted)

INSERT INTO NotificationEmails (Recipient, Subject, Body) VALUES
(
	@accountId,
	'Balance change for account: ' + CAST(@accountId AS VARCHAR(20)),
	'On ' + CONVERT(VARCHAR(30),GETDATE(),103) + ' your balance was changed from ' + CAST(@oldSum AS VARCHAR(20)) + ' to ' + CAST(@newSum AS VARCHAR(20))
)