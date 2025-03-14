USE [PSI20M_AfonsoAraujo_2220100]
GO
/****** Object:  Table [dbo].[Aquisicao_equipamentos]    Script Date: 27/06/2022 19:33:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aquisicao_equipamentos](
	[id_aquisicao] [int] NOT NULL,
	[data_limite_rececao] [varchar](10) NOT NULL,
	[quantidade_aquisicao] [int] NOT NULL,
	[entidade] [varchar](50) NOT NULL,
	[motivo] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_aquisicao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aquisicao_inflamaveis]    Script Date: 27/06/2022 19:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aquisicao_inflamaveis](
	[id_aquisicao] [int] NOT NULL,
	[data_limite_rececao] [varchar](10) NOT NULL,
	[quantidade_aquisicao] [int] NOT NULL,
	[entidade] [varchar](50) NOT NULL,
	[motivo] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_aquisicao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aquisicao_medicamentos]    Script Date: 27/06/2022 19:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aquisicao_medicamentos](
	[id_aquisicao] [int] NOT NULL,
	[data_limite_rececao] [varchar](50) NOT NULL,
	[quantidade_aquisicao] [int] NOT NULL,
	[entidade] [varchar](50) NOT NULL,
	[motivo] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_aquisicao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipamentos]    Script Date: 27/06/2022 19:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipamentos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[denominacao] [varchar](256) NOT NULL,
	[lote] [int] NOT NULL,
	[quantidade] [int] NOT NULL,
	[numero_serie] [varchar](9) NOT NULL,
	[fabricante] [varchar](50) NOT NULL,
	[email_tel_fabricante] [varchar](50) NOT NULL,
	[setor] [varchar](1) NOT NULL,
	[observacoes] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecimento_equipamentos]    Script Date: 27/06/2022 19:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecimento_equipamentos](
	[id_fornecimento] [int] NOT NULL,
	[data_fornecimento] [varchar](10) NOT NULL,
	[quantidade_fornecimento] [int] NOT NULL,
	[data_entrega] [varchar](10) NOT NULL,
	[entidade] [varchar](50) NOT NULL,
	[observacoes] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_fornecimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecimento_inflamaveis]    Script Date: 27/06/2022 19:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecimento_inflamaveis](
	[id_fornecimento] [int] NOT NULL,
	[data_fornecimento] [varchar](10) NOT NULL,
	[quantidade_fornecimento] [int] NOT NULL,
	[data_entrega] [varchar](10) NOT NULL,
	[entidade] [varchar](50) NOT NULL,
	[observacoes] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_fornecimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecimento_medicamentos]    Script Date: 27/06/2022 19:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecimento_medicamentos](
	[id_fornecimento] [int] NOT NULL,
	[data_fornecimento] [varchar](50) NOT NULL,
	[quantidade_fornecimento] [int] NOT NULL,
	[data_entrega] [varchar](50) NOT NULL,
	[entidade] [varchar](50) NOT NULL,
	[observacoes] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_fornecimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inflamaveis]    Script Date: 27/06/2022 19:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inflamaveis](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[denominacao] [varchar](256) NOT NULL,
	[validade] [varchar](10) NOT NULL,
	[lote] [int] NOT NULL,
	[quantidade] [int] NOT NULL,
	[numero_serie] [varchar](9) NOT NULL,
	[fabricante] [varchar](50) NOT NULL,
	[email_tel_fabricante] [varchar](50) NOT NULL,
	[setor] [varchar](1) NOT NULL,
	[observacoes] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicamentos]    Script Date: 27/06/2022 19:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicamentos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[denominacao] [varchar](256) NOT NULL,
	[principio_ativo] [varchar](256) NOT NULL,
	[validade] [varchar](50) NOT NULL,
	[lote] [int] NOT NULL,
	[quantidade] [int] NOT NULL,
	[fabricante] [varchar](50) NOT NULL,
	[email_tel_fabricante] [varchar](50) NOT NULL,
	[setor] [varchar](1) NOT NULL,
	[observacoes] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilizadores]    Script Date: 27/06/2022 19:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilizadores](
	[id_utilizador] [int] NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[username] [varchar](30) NOT NULL,
	[password] [varchar](30) NOT NULL,
	[genero] [varchar](1) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[num_tel] [varchar](9) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_utilizador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Aquisicao_equipamentos] ([id_aquisicao], [data_limite_rececao], [quantidade_aquisicao], [entidade], [motivo]) VALUES (20, N'17/06/2022', 12, N'12', N'12')
INSERT [dbo].[Aquisicao_equipamentos] ([id_aquisicao], [data_limite_rececao], [quantidade_aquisicao], [entidade], [motivo]) VALUES (21, N'17/06/2022', 23, N'Littmann', N'23')
GO
INSERT [dbo].[Aquisicao_inflamaveis] ([id_aquisicao], [data_limite_rececao], [quantidade_aquisicao], [entidade], [motivo]) VALUES (4, N'14/06/2022', 100, N'DLS', N'É necessário mais unidades.')
INSERT [dbo].[Aquisicao_inflamaveis] ([id_aquisicao], [data_limite_rececao], [quantidade_aquisicao], [entidade], [motivo]) VALUES (16, N'27/06/2022', 100, N'Alma & João', N'Missão Humanitária, necessário repor stock.')
INSERT [dbo].[Aquisicao_inflamaveis] ([id_aquisicao], [data_limite_rececao], [quantidade_aquisicao], [entidade], [motivo]) VALUES (20, N'27/06/2022', 100, N'Lapos ', N'É necessário mais unidades.')
GO
INSERT [dbo].[Aquisicao_medicamentos] ([id_aquisicao], [data_limite_rececao], [quantidade_aquisicao], [entidade], [motivo]) VALUES (35, N'25/06/2022', 300, N'GSK', N'Pouco stock')
INSERT [dbo].[Aquisicao_medicamentos] ([id_aquisicao], [data_limite_rececao], [quantidade_aquisicao], [entidade], [motivo]) VALUES (43, N'23/06/2022', 200, N'Bluepharma', N'Pouco stock')
INSERT [dbo].[Aquisicao_medicamentos] ([id_aquisicao], [data_limite_rececao], [quantidade_aquisicao], [entidade], [motivo]) VALUES (49, N'18/06/2022', 300, N'Ratiopharm', N'Medicamento prestes a expirar ')
INSERT [dbo].[Aquisicao_medicamentos] ([id_aquisicao], [data_limite_rececao], [quantidade_aquisicao], [entidade], [motivo]) VALUES (53, N'29/06/2022', 360, N'MAR&TERRA', N'É necessário mais unidades devido a uma falha NRP Sines')
GO
SET IDENTITY_INSERT [dbo].[Equipamentos] ON 

INSERT [dbo].[Equipamentos] ([id], [denominacao], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (16, N'Estetoscópio Littmann', 45465, 60, N'144643543', N'Littmann', N'litmann@sapo.pt', N'E', N'')
INSERT [dbo].[Equipamentos] ([id], [denominacao], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (17, N'Bolsa médica sanitária', 45656, 30, N'356543543', N'Sporthealth', N'sporthealth@gmail.com', N'B', N'')
INSERT [dbo].[Equipamentos] ([id], [denominacao], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (18, N'Túnica Hospitalar', 21354, 200, N'354635847', N'Garcia Hostal', N'garciahostal@sapo.pt', N'T', N'')
INSERT [dbo].[Equipamentos] ([id], [denominacao], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (19, N'Socas Wock Bloc', 35683, 300, N'154784353', N'Bloc', N'block@hotrmail.com', N'S', N'')
INSERT [dbo].[Equipamentos] ([id], [denominacao], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (20, N'Ecógrafo de Ultra-sons Digital Portátil ', 35468, 40, N'687798641', N'WED', N'wed@hotmail.com', N'E', N'')
INSERT [dbo].[Equipamentos] ([id], [denominacao], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (21, N'HM70A Carrinho de ecógrafias', 46678, 15, N'654651532', N'Samsung ', N'samsung@gmail.com', N'H', N'')
INSERT [dbo].[Equipamentos] ([id], [denominacao], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (22, N'Espéculo nasal', 58768, 20, N'154464657', N'Econom', N'econom@sapo.com', N'E', N'')
INSERT [dbo].[Equipamentos] ([id], [denominacao], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (23, N'Ardes M213', 45646, 30, N'354684354', N'HealthCare', N'healthcare@hotmail.com', N'A', N'')
INSERT [dbo].[Equipamentos] ([id], [denominacao], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (24, N'Oxímetro ', 65462, 8, N'657684353', N'DisplayMedical', N'displaymedical@gmail.com', N'O', N'')
INSERT [dbo].[Equipamentos] ([id], [denominacao], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (25, N'Otoscópio ', 65643, 30, N'146547658', N'Alihop', N'alihop@gmail.com', N'O', N'')
SET IDENTITY_INSERT [dbo].[Equipamentos] OFF
GO
INSERT [dbo].[Fornecimento_equipamentos] ([id_fornecimento], [data_fornecimento], [quantidade_fornecimento], [data_entrega], [entidade], [observacoes]) VALUES (19, N'27/06/2022', 25, N'27/06/2022', N'NRP Corte-Real F332', N'')
INSERT [dbo].[Fornecimento_equipamentos] ([id_fornecimento], [data_fornecimento], [quantidade_fornecimento], [data_entrega], [entidade], [observacoes]) VALUES (25, N'27/06/2022', 10, N'27/06/2022', N'NRP Afonso Cerqueira F488', N'')
GO
INSERT [dbo].[Fornecimento_inflamaveis] ([id_fornecimento], [data_fornecimento], [quantidade_fornecimento], [data_entrega], [entidade], [observacoes]) VALUES (3, N'27/06/2022', 25, N'29/07/2022', N'NRP Sines P362', N'')
INSERT [dbo].[Fornecimento_inflamaveis] ([id_fornecimento], [data_fornecimento], [quantidade_fornecimento], [data_entrega], [entidade], [observacoes]) VALUES (16, N'27/06/2022', 90, N'02/07/2022', N'NRP Oríon P1156', N'')
INSERT [dbo].[Fornecimento_inflamaveis] ([id_fornecimento], [data_fornecimento], [quantidade_fornecimento], [data_entrega], [entidade], [observacoes]) VALUES (21, N'27/06/2022', 25, N'27/06/2022', N'NRP Setúbal P363', N'')
GO
INSERT [dbo].[Fornecimento_medicamentos] ([id_fornecimento], [data_fornecimento], [quantidade_fornecimento], [data_entrega], [entidade], [observacoes]) VALUES (52, N'24/06/2022', 20, N'09/07/2022', N'NRP Setúbal P363', N'')
GO
SET IDENTITY_INSERT [dbo].[Inflamaveis] ON 

INSERT [dbo].[Inflamaveis] ([id], [denominacao], [validade], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (3, N'Alcool', N'18-10-2022', 25638, 241, N'529632478', N'Koppert', N'koppert@gmail.com', N'P', N'')
INSERT [dbo].[Inflamaveis] ([id], [denominacao], [validade], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (4, N'Alcool Em Gel', N'14-09-2023', 19658, 100, N'526394825', N'Koppert', N'koppert@gmail.com', N'F', N'')
INSERT [dbo].[Inflamaveis] ([id], [denominacao], [validade], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (15, N'Benzeno', N'25-07-2024', 65687, 320, N'529687741', N'Lapos ', N'lapos@sapo.pt', N'B', N'')
INSERT [dbo].[Inflamaveis] ([id], [denominacao], [validade], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (16, N'Acetileno', N'26-03-2025', 21354, 250, N'354687654', N'Stopolis', N'stopolis@hotmail.com', N'A', N'')
INSERT [dbo].[Inflamaveis] ([id], [denominacao], [validade], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (17, N'Etanol', N'29-03-2027', 25351, 150, N'356584656', N'Etanideos', N'etanideos@gmail.com', N'E', N'')
INSERT [dbo].[Inflamaveis] ([id], [denominacao], [validade], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (18, N'Amoníaco', N'01-09-2026', 32464, 450, N'465463465', N'Alma & João', N'almajoao@sapo.pt', N'A', N'')
INSERT [dbo].[Inflamaveis] ([id], [denominacao], [validade], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (19, N'Propano', N'04-08-2022', 55646, 150, N'354654541', N'Propslop', N'propslop@hotmail.com', N'P', N'')
INSERT [dbo].[Inflamaveis] ([id], [denominacao], [validade], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (20, N'Sulfeto de hidrogênio', N'04-11-2025', 54864, 0, N'146846354', N'Ricban', N'ricban@sapo.com', N'S', N'')
INSERT [dbo].[Inflamaveis] ([id], [denominacao], [validade], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (21, N'Dióxido de carbono', N'04-03-2030', 56846, 50, N'654476854', N'Ricban', N'ricban@sapo.com', N'D', N'')
INSERT [dbo].[Inflamaveis] ([id], [denominacao], [validade], [lote], [quantidade], [numero_serie], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (22, N'Monóxido de carbono', N'19-11-2024', 25656, 60, N'847684356', N'Ricban', N'ricban@sapo.com', N'M', N'')
SET IDENTITY_INSERT [dbo].[Inflamaveis] OFF
GO
SET IDENTITY_INSERT [dbo].[Medicamentos] ON 

INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (2, N'Brufen', N'Anti-inflamatório', N'20-07-2025', 12121, 250, N'MAR&TERRA', N'marterra@gmail.com', N'B', N'')
INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (35, N'Lamicrem', N'Trolamina', N'12-06-2027', 56120, 110, N'GSK', N'gsk@gmail.com', N'L', N'Para uso externo')
INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (39, N'Strepfen', N'Flurbiprofeno', N'20/07/2024', 39587, 260, N'Reckitt Benckiser', N'reckittbenckiser@gmail.com', N'S', N'Pastilhas ação anti-inflamatória, não dar a menores de 12 anos.')
INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (40, N'Telfast 180', N'Anti-Histamínico', N'03/03/2026', 66341, 300, N'Opella Healthcare', N'opellahealthcare@sapo.pt', N'T', N'')
INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (41, N'Griponal', N'Paracetemol', N'08-08-2024', 28956, 165, N'P&G Health GmbH', N'gmbH@hotmail.com', N'G', N'Febre,constipações.')
INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (42, N'Fluimucil', N'Acetilcisteína', N'10-03-2023', 23987, 410, N'Zambon', N'zambon@sapo.pt', N'Z', N'')
INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (43, N'Daflagan', N'Paracetemol', N'30/12/2022', 85412, 25, N'Bristol-Myers', N'bristol@hotmail.com', N'D', N'Uso externo e interno com presquição necessária.')
INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (44, N'BilaXten', N'Bilastina', N'20/03/2024', 48596, 362, N'laboratórios Vitória', N'vitoria@gmail.com', N'B', N'')
INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (45, N'Diclonfenac Labesfal', N'Diclonfenac Sódio', N'10/03/2023', 33847, 307, N'generis', N'generis@sapo.pt', N'D', N'')
INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (46, N'Indapamida toLife', N'Indapamida ', N'02/10/2026', 15823, 350, N'toLife', N'tolife@hotmail.com', N'I', N'')
INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (47, N'Microlax', N'Enema citrato', N'25/03/2025', 36741, 326, N'Jaba Recordati', N'jaba@gmail.com', N'M', N'Bisnagas individuais dose única.')
INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (48, N'Pantoprazol', N'Gastrorresistentes', N'08/11/2023', 19856, 315, N'Ratiopharm', N'ratiopharm@sapo.pt', N'P', N'Comprimitos para tomar via oral.')
INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (49, N'Pulmicort', N'Budesonida', N'27/06/2023', 95741, 350, N'Johnson & Johnson ', N'johnson@hotmail.com', N'P', N'1 frasco com 120 doses para pulverização nasal.')
INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (50, N'Aldagur', N'Paracetemol', N'09/07/2026', 52921, 260, N'Angelini', N'angelini@gmail.com', N'A', N'')
INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (51, N'Melatonina Pura', N'Microcomprimidos', N'17-12-2024', 15742, 200, N'ESI', N'esi@sapo.com', N'M', N'')
INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (52, N'Ondansetrom toLife', N'Orodispersiveis', N'23/01/2025', 11896, 310, N'toLife', N'tolife@hotmail.com', N'O', N'')
INSERT [dbo].[Medicamentos] ([id], [denominacao], [principio_ativo], [validade], [lote], [quantidade], [fabricante], [email_tel_fabricante], [setor], [observacoes]) VALUES (53, N'Cetirzina', N'Dicloridrato de cetirina', N'08-10-2026', 41896, 100, N'Bluepharma', N'Bluepharma@gmail.com', N'C', N'Comprimidos com uso regulado.Uso não regulado pode dar problemas de saúde. ')
SET IDENTITY_INSERT [dbo].[Medicamentos] OFF
GO
INSERT [dbo].[Utilizadores] ([id_utilizador], [nome], [username], [password], [genero], [email], [num_tel]) VALUES (1, N'Afonso Araújo ', N'AdminAA22', N'AdminAA22', N'M', N'afonso16araujo@gmail.com', N'910947908')
INSERT [dbo].[Utilizadores] ([id_utilizador], [nome], [username], [password], [genero], [email], [num_tel]) VALUES (3, N'Manuel Antonio', N'CaboCA92', N'1234', N'M', N'caboca@gmail.com', N'936852741')
INSERT [dbo].[Utilizadores] ([id_utilizador], [nome], [username], [password], [genero], [email], [num_tel]) VALUES (4, N'Antonia Oliveira', N'SargentoAO87', N'1234', N'F', N'antoniaoliveira@gmail.com', N'924320480')
INSERT [dbo].[Utilizadores] ([id_utilizador], [nome], [username], [password], [genero], [email], [num_tel]) VALUES (5, N'Maria Marta Oliveira', N'PraçaMO95', N'1234', N'F', N'afonso16araujo@gmail.com', N'912345677')
INSERT [dbo].[Utilizadores] ([id_utilizador], [nome], [username], [password], [genero], [email], [num_tel]) VALUES (6, N'teste', N'teste', N'teste', N'M', N'teste@gmail.com', N'910947908')
GO
ALTER TABLE [dbo].[Aquisicao_equipamentos]  WITH CHECK ADD FOREIGN KEY([id_aquisicao])
REFERENCES [dbo].[Equipamentos] ([id])
GO
ALTER TABLE [dbo].[Aquisicao_inflamaveis]  WITH CHECK ADD FOREIGN KEY([id_aquisicao])
REFERENCES [dbo].[Inflamaveis] ([id])
GO
ALTER TABLE [dbo].[Aquisicao_medicamentos]  WITH CHECK ADD FOREIGN KEY([id_aquisicao])
REFERENCES [dbo].[Medicamentos] ([id])
GO
ALTER TABLE [dbo].[Fornecimento_equipamentos]  WITH CHECK ADD FOREIGN KEY([id_fornecimento])
REFERENCES [dbo].[Equipamentos] ([id])
GO
ALTER TABLE [dbo].[Fornecimento_inflamaveis]  WITH CHECK ADD FOREIGN KEY([id_fornecimento])
REFERENCES [dbo].[Inflamaveis] ([id])
GO
ALTER TABLE [dbo].[Fornecimento_medicamentos]  WITH CHECK ADD FOREIGN KEY([id_fornecimento])
REFERENCES [dbo].[Medicamentos] ([id])
GO
