USE [18017_DB]
GO

/****** Object:  Index [korisnik_unq]    Script Date: 3.7.2018. 18:09:18 ******/
ALTER TABLE [dbo].[korisnik] ADD  CONSTRAINT [korisnik_unq] UNIQUE NONCLUSTERED 
(
	[korisnicko_ime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

