USE [18017_DB]
GO

/****** Object:  Index [znacenje_unq]    Script Date: 3.7.2018. 18:09:01 ******/
ALTER TABLE [dbo].[jedinica_mjere] ADD  CONSTRAINT [znacenje_unq] UNIQUE NONCLUSTERED 
(
	[znacenje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

