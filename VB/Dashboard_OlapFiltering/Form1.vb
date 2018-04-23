Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.DashboardCommon
Imports DevExpress.Data.Filtering

Namespace Dashboard_OlapFiltering
    Partial Public Class Form1
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
            dashboardDesigner1.CreateRibbon()
            Dim dashboard As New Dashboard()
            dashboard.LoadFromXml("..\..\Data\Dashboard.xml")
            Dim pivot1 As PivotDashboardItem = CType(dashboard.Items(0), PivotDashboardItem)
            Dim olapDataSource As DashboardOlapDataSource =
                CType(dashboard.DataSources(0), DashboardOlapDataSource)

            Dim fieldYearName As String = "[Date].[Calendar].[Calendar Year]"
            Dim year2001 As String = "[Date].[Calendar].[Calendar Year].&[2001]"
            Dim year2002 As String = "[Date].[Calendar].[Calendar Year].&[2002]"

            Dim fieldCountryName As String = "[Customer].[Country].[Country]"
            Dim countryCanada As String = "[Customer].[Country].&[Canada]"

            Dim settings As New DynamicListLookUpSettings()
            settings.DataSource = olapDataSource
            settings.ValueMember = fieldCountryName
            Dim parameter1 As New DashboardParameter("Parameter1", _
                                  GetType(String), countryCanada, "Category", True, settings)
            dashboard.Parameters.Add(parameter1)

            Dim filterCriteria As CriteriaOperator = GroupOperator.And( _
                New BinaryOperator(New OperandProperty(fieldCountryName), _
                                   New OperandParameter(parameter1.Name), _
                                   BinaryOperatorType.Equal), _
                New NotOperator(New InOperator(New OperandProperty(fieldYearName), _
                                               New ConstantValue() {New ConstantValue(year2001), _
                                                                    New ConstantValue(year2002)})))

            pivot1.FilterString = filterCriteria.ToString()
            dashboardDesigner1.Dashboard = dashboard
        End Sub
    End Class
End Namespace
