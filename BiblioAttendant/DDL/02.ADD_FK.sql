
USE [BiblioAttendant]

ALTER TABLE [BOOK_DETAIL] ADD CONSTRAINT [FK_BOOK_DETAIL]
	FOREIGN KEY ([ISBN_NO]) REFERENCES [BOOK] ([ISBN_NO]) ON DELETE No Action ON UPDATE No Action
GO
