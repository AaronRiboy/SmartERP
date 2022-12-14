USE [NewLicenseDB]
GO
/****** Object:  Table [dbo].[AcBusinessNature]    Script Date: 11/25/2022 5:25:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcBusinessNature](
	[AcBusinessNatureID] [nvarchar](100) NOT NULL,
	[AcBusinessNatureDesc] [nvarchar](100) NOT NULL,
	[OrderNo] [int] NOT NULL,
	[CreateBy] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[EditBy] [nvarchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Stamp] [int] NOT NULL,
	[AcBusinessNatureGrpId] [nvarchar](20) NULL,
 CONSTRAINT [PK_AcBusinessNature] PRIMARY KEY CLUSTERED 
(
	[AcBusinessNatureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AcBusinessNatureGrp]    Script Date: 11/25/2022 5:25:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcBusinessNatureGrp](
	[AcBusinessNatureGrpID] [nvarchar](100) NOT NULL,
	[AcBusinessNatureGrpDesc] [nvarchar](100) NOT NULL,
	[CreateBy] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[EditBy] [nvarchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Stamp] [int] NOT NULL,
 CONSTRAINT [PK_AcBusinessNatureGrp] PRIMARY KEY CLUSTERED 
(
	[AcBusinessNatureGrpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AcCompanyGroup]    Script Date: 11/25/2022 5:25:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcCompanyGroup](
	[AcCompanyGroupID] [nvarchar](100) NOT NULL,
	[AcCompanyGroupDesc] [nvarchar](100) NOT NULL,
	[DealerID] [nvarchar](50) NOT NULL,
	[CreateBy] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[EditBy] [nvarchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Stamp] [int] NOT NULL,
	[ACTIVE] [nvarchar](1) NULL,
	[ContactPerson] [nvarchar](50) NULL,
	[ContactEmail] [nvarchar](50) NULL,
	[ContactNo] [nvarchar](20) NULL,
	[SLCRenewDate] [datetime] NULL,
	[SLCExpiryDate] [datetime] NULL,
	[Remark] [nvarchar](max) NULL,
	[SLCAmount] [money] NULL,
	[TotalInCardMember] [int] NULL,
	[LastFollowUpDate] [datetime] NULL,
	[TotalPos] [int] NULL,
	[NumberOfOutlet] [int] NULL,
	[IntegrationTo] [nvarchar](100) NULL,
	[AcBusinessNatureId] [nvarchar](100) NULL,
	[AcCustomerStatusId] [nvarchar](20) NULL,
	[masterdealer] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_AcCompanyGroup] PRIMARY KEY CLUSTERED 
(
	[AcCompanyGroupID] ASC,
	[DealerID] ASC,
	[masterdealer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AcCountry]    Script Date: 11/25/2022 5:25:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcCountry](
	[AcCountryID] [nvarchar](20) NOT NULL,
	[AcCountryDesc] [nvarchar](100) NOT NULL,
	[CreateBy] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[EditBy] [nvarchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Stamp] [int] NOT NULL,
 CONSTRAINT [PK_AcCountry] PRIMARY KEY CLUSTERED 
(
	[AcCountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AcCustomerStatus]    Script Date: 11/25/2022 5:25:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcCustomerStatus](
	[AcCustomerStatusID] [nvarchar](20) NOT NULL,
	[AcCustomerStatusDesc] [nvarchar](100) NOT NULL,
	[CreateBy] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[EditBy] [nvarchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Stamp] [int] NOT NULL,
 CONSTRAINT [PK_AcCustomerStatus] PRIMARY KEY CLUSTERED 
(
	[AcCustomerStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AcDealer]    Script Date: 11/25/2022 5:25:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcDealer](
	[MasterDealer] [nvarchar](20) NOT NULL,
	[DealerID] [nvarchar](20) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[ContactNo] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Country] [nvarchar](100) NOT NULL,
	[State] [nvarchar](100) NOT NULL,
	[City] [nvarchar](100) NOT NULL,
	[PostCode] [nvarchar](10) NOT NULL,
	[IsSubDealer] [nvarchar](1) NOT NULL,
	[Active] [nvarchar](1) NOT NULL,
	[CreateBy] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[EditBy] [nvarchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Stamp] [int] NOT NULL,
	[CoverDocNoPreFix] [nvarchar](50) NULL,
	[CoverLastDocNo] [int] NULL,
	[IsTaxExclusive] [nvarchar](1) NULL,
 CONSTRAINT [PK_AcDealer] PRIMARY KEY CLUSTERED 
(
	[MasterDealer] ASC,
	[DealerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AcLeadSource]    Script Date: 11/25/2022 5:25:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcLeadSource](
	[AcLeadSourceID] [nvarchar](20) NOT NULL,
	[AcLeadSourceDesc] [nvarchar](100) NOT NULL,
	[CreateBy] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[EditBy] [nvarchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Stamp] [int] NOT NULL,
 CONSTRAINT [PK_AcLeadSource] PRIMARY KEY CLUSTERED 
(
	[AcLeadSourceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AcLeadStatus]    Script Date: 11/25/2022 5:25:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcLeadStatus](
	[AcLeadStatusID] [nvarchar](20) NOT NULL,
	[AcLeadStatusDesc] [nvarchar](100) NOT NULL,
	[CreateBy] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[EditBy] [nvarchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Stamp] [int] NOT NULL,
 CONSTRAINT [PK_AcLeadStatus] PRIMARY KEY CLUSTERED 
(
	[AcLeadStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AcLicenseInfo]    Script Date: 11/25/2022 5:25:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcLicenseInfo](
	[Regkey] [nvarchar](50) NULL,
	[CompanyName] [nvarchar](100) NULL,
	[CompanyGroupID] [nvarchar](100) NULL,
	[CompanyRoc] [nvarchar](50) NULL,
	[Address1] [nvarchar](100) NULL,
	[Address2] [nvarchar](100) NULL,
	[Address3] [nvarchar](100) NULL,
	[Address4] [nvarchar](100) NULL,
	[Telephone] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Website] [nvarchar](100) NULL,
	[ContactPerson] [nvarchar](100) NULL,
	[Business] [nvarchar](100) NULL,
	[SerialKey] [nvarchar](50) NOT NULL,
	[CardGroup] [nvarchar](10) NULL,
	[DealerId] [nvarchar](20) NULL,
	[DealerCompany] [nvarchar](100) NULL,
	[DealerContact] [nvarchar](100) NULL,
	[DealerTelephone] [nvarchar](50) NULL,
	[DealerFax] [nvarchar](50) NULL,
	[DealerEmail] [nvarchar](50) NULL,
	[DealerWebsite] [nvarchar](100) NULL,
	[CountryID] [nvarchar](20) NULL,
	[SignatureId] [nvarchar](150) NULL,
	[LicenseKey] [nvarchar](150) NULL,
	[Productcode] [nvarchar](50) NULL,
	[ProductDescription] [nvarchar](100) NULL,
	[DatePurchase] [datetime] NULL,
	[ActivateDate] [datetime] NULL,
	[Remark] [nvarchar](200) NULL,
	[SecurityCode] [nvarchar](50) NULL,
	[SecurityCodeGenBy] [nvarchar](50) NULL,
	[SecurityCodeGenDate] [datetime] NULL,
	[PartnerRemark] [nvarchar](500) NULL,
	[TransferTo] [nvarchar](50) NULL,
	[TransferBy] [nvarchar](50) NULL,
	[TransferDate] [datetime] NULL,
	[TransferRemark] [nvarchar](200) NULL,
	[CoverForSerialKey] [nvarchar](50) NULL,
	[CoverExpiryDate] [datetime] NULL,
	[CoverActivateBy] [nvarchar](50) NULL,
	[CoverActivateDate] [datetime] NULL,
	[CoverVersion] [int] NULL,
	[IsBlock] [nvarchar](1) NULL,
	[BlockBy] [nvarchar](50) NULL,
	[BlockCreateDate] [datetime] NULL,
	[BlockFromDate] [datetime] NULL,
	[BlockRemark] [nvarchar](200) NULL,
	[MsgId] [nvarchar](20) NULL,
	[IsVoid] [nvarchar](1) NULL,
	[VoidBy] [nvarchar](50) NULL,
	[VoidDate] [datetime] NULL,
	[VoidRemark] [nvarchar](200) NULL,
	[IsActivate] [nvarchar](1) NULL,
	[IsLicenseReady] [nvarchar](1) NULL,
	[LicenseKeyV1] [nvarchar](150) NULL,
	[ForceRecertifyDate] [datetime] NULL,
	[ReserveFor] [nvarchar](100) NULL,
	[SubDealerId] [nvarchar](20) NULL,
	[IsCoverPlus] [nvarchar](1) NULL,
	[TwoInOneKey] [nvarchar](1) NULL,
 CONSTRAINT [PK_AcLicenseInfo] PRIMARY KEY CLUSTERED 
(
	[SerialKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AcSalesPerson]    Script Date: 11/25/2022 5:25:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcSalesPerson](
	[MasterDealer] [nvarchar](20) NOT NULL,
	[DealerID] [nvarchar](20) NOT NULL,
	[AcSalesPersonID] [nvarchar](100) NOT NULL,
	[AcSalesPersonDesc] [nvarchar](100) NOT NULL,
	[CreateBy] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[EditBy] [nvarchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Stamp] [int] NOT NULL,
 CONSTRAINT [PK_AcSalesPerson] PRIMARY KEY CLUSTERED 
(
	[MasterDealer] ASC,
	[DealerID] ASC,
	[AcSalesPersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AcUser]    Script Date: 11/25/2022 5:25:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcUser](
	[AcUserID] [nvarchar](50) NOT NULL,
	[DealerID] [nvarchar](20) NOT NULL,
	[MasterDealer] [nvarchar](20) NOT NULL,
	[AcUserGroupID] [nvarchar](20) NOT NULL,
	[PwdLogin] [nvarchar](100) NOT NULL,
	[Active] [nvarchar](1) NOT NULL,
	[Remark] [nvarchar](50) NULL,
	[CreateBy] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[EditBy] [nvarchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Stamp] [int] NOT NULL,
	[IsTaxExclusive] [nvarchar](1) NULL,
 CONSTRAINT [PK_AcUser] PRIMARY KEY CLUSTERED 
(
	[AcUserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AcUserGroup]    Script Date: 11/25/2022 5:25:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcUserGroup](
	[AcUserGroupID] [nvarchar](20) NOT NULL,
	[AcUserGroupDesc] [nvarchar](100) NOT NULL,
	[IsSmartStaff] [nvarchar](1) NOT NULL,
	[CreateBy] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[EditBy] [nvarchar](50) NULL,
	[EditDate] [datetime] NULL,
	[Stamp] [int] NOT NULL,
 CONSTRAINT [PK_AcUserGroup] PRIMARY KEY CLUSTERED 
(
	[AcUserGroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AcBusinessNature] ADD  CONSTRAINT [DF_AcBusinessNature_OrderNo]  DEFAULT ((0)) FOR [OrderNo]
GO
ALTER TABLE [dbo].[AcBusinessNature] ADD  CONSTRAINT [DF_AcBusinessNature_Stamp]  DEFAULT ((0)) FOR [Stamp]
GO
ALTER TABLE [dbo].[AcBusinessNatureGrp] ADD  CONSTRAINT [DF_AcBusinessNatureGrp_Stamp]  DEFAULT ((0)) FOR [Stamp]
GO
ALTER TABLE [dbo].[AcCompanyGroup] ADD  CONSTRAINT [DF_AcCompanyGroup_Stamp]  DEFAULT ((0)) FOR [Stamp]
GO
ALTER TABLE [dbo].[AcCountry] ADD  CONSTRAINT [DF_AcCountry_Stamp]  DEFAULT ((0)) FOR [Stamp]
GO
ALTER TABLE [dbo].[AcCustomerStatus] ADD  CONSTRAINT [DF_AcCustomerStatus_Stamp]  DEFAULT ((0)) FOR [Stamp]
GO
ALTER TABLE [dbo].[AcDealer] ADD  CONSTRAINT [DF_AcDealer_stamp]  DEFAULT ((0)) FOR [Stamp]
GO
ALTER TABLE [dbo].[AcLeadSource] ADD  CONSTRAINT [DF_AcLeadSource_Stamp]  DEFAULT ((0)) FOR [Stamp]
GO
ALTER TABLE [dbo].[AcLeadStatus] ADD  CONSTRAINT [DF_AcLeadStatus_Stamp]  DEFAULT ((0)) FOR [Stamp]
GO
ALTER TABLE [dbo].[AcSalesPerson] ADD  CONSTRAINT [DF_AcSalesPerson_Stamp]  DEFAULT ((0)) FOR [Stamp]
GO
ALTER TABLE [dbo].[AcUser] ADD  CONSTRAINT [DF_AcUser_stamp]  DEFAULT ((0)) FOR [Stamp]
GO
ALTER TABLE [dbo].[AcUserGroup] ADD  CONSTRAINT [DF_AcUserGroup_Stamp]  DEFAULT ((0)) FOR [Stamp]
GO
ALTER TABLE [dbo].[AcUser]  WITH CHECK ADD  CONSTRAINT [FK_AcUser_AcUserGroup] FOREIGN KEY([AcUserGroupID])
REFERENCES [dbo].[AcUserGroup] ([AcUserGroupID])
GO
ALTER TABLE [dbo].[AcUser] CHECK CONSTRAINT [FK_AcUser_AcUserGroup]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User ID. The value must also exists in Database Instance Security Login.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AcUser', @level2type=N'COLUMN',@level2name=N'AcUserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User Login Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AcUser', @level2type=N'COLUMN',@level2name=N'DealerID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User Group ID. FK to AcUserGroup.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AcUser', @level2type=N'COLUMN',@level2name=N'AcUserGroupID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Password to Login into System. Encrypted. Note: Input password to be Min 6 and Max 20 Alpha-Numeric Characters.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AcUser', @level2type=N'COLUMN',@level2name=N'PwdLogin'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Login User' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AcUser'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User Group ID. PK.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AcUserGroup', @level2type=N'COLUMN',@level2name=N'AcUserGroupID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User Group Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AcUserGroup', @level2type=N'COLUMN',@level2name=N'AcUserGroupDesc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User Group Table. Security Access Right will grant through this table.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AcUserGroup'
GO
