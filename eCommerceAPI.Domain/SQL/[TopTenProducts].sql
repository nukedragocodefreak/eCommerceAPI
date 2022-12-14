USE [ECommerce]
GO
/****** Object:  StoredProcedure [dbo].[TopTenProducts]    Script Date: 2022/08/23 00:25:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 -- =============================================
-- Author:		Noel Mangwarira
-- Create date: 2022/08/23
-- Description:	get the blacklisted bank accounts
-- =============================================
ALTER PROCEDURE [dbo].[TopTenProducts] 
	-- Add the parameters for the stored procedure here
	@startdate DATETIME
AS
BEGIN
	BEGIN TRY
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;

SELECT DISTINCT TOP (10) COUNT(p.[ProductId])
      ,p.[ProductName]
      ,p.[Price]
      ,p.[Weight]
      ,p.[StockAmount]
      ,p.[CategoryId]
      ,od.Quantity,
	  c.Customername
  FROM [ECommerce].[dbo].[Products] p
  INNER JOIN OrderDetails od ON od.ProductId = p.ProductId
  INNER JOIN Orders o ON o.OrderId = od.OrderId
  INNER JOIN Customers c ON c.Customerid = o.CustomerId
  WHERE o.OrderDate  BETWEEN DATEADD(MONTH, -3, @startdate) AND @startdate  
  GROUP BY p.[ProductName]
		  ,p.[Price]
		  ,p.[Weight]
		  ,p.[StockAmount]
		  ,p.[CategoryId]
		  ,od.Quantity,
		  c.Customername

	ORDER BY  c.Customername


	END TRY
	BEGIN CATCH
		DECLARE @SysErrorMessage VARCHAR(MAX) = ERROR_MESSAGE()
		,@ErrorSev INT = ERROR_SEVERITY()
		,@ErrorSate INT = ERROR_STATE();
		RAISERROR (N'dbo.[TopTenProducts]: %s', -- Message text i.e Procedure name.
		@ErrorSev, -- Severity,
		@ErrorSate, -- State,
		@SysErrorMessage);

	END CATCH
END
