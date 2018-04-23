using DevExpress.XtraBars.Ribbon;
using DevExpress.DashboardCommon;
using DevExpress.Data.Filtering;

namespace Dashboard_OlapFiltering {
    public partial class Form1 : RibbonForm {
        public Form1() {
            InitializeComponent();
            dashboardDesigner1.CreateRibbon();
            Dashboard dashboard = new Dashboard();
            dashboard.LoadFromXml(@"..\..\Data\Dashboard.xml");
            PivotDashboardItem pivot1 = (PivotDashboardItem)dashboard.Items[0];
            DashboardOlapDataSource olapDataSource = (DashboardOlapDataSource)dashboard.DataSources[0];

            string fieldYearName = "[Date].[Calendar].[Calendar Year]";
            string year2001 = "[Date].[Calendar].[Calendar Year].&[2001]";
            string year2002 = "[Date].[Calendar].[Calendar Year].&[2002]";

            string fieldCountryName = "[Customer].[Country].[Country]";
            string countryCanada = "[Customer].[Country].&[Canada]";

            DynamicListLookUpSettings settings = new DynamicListLookUpSettings();
            settings.DataSource = olapDataSource;
            settings.ValueMember = fieldCountryName;
            DashboardParameter parameter1 = new DashboardParameter("Parameter1", 
                typeof(string), countryCanada, "Category", true, settings);
            dashboard.Parameters.Add(parameter1);

            CriteriaOperator filterCriteria = GroupOperator.And(
                new BinaryOperator(new OperandProperty(fieldCountryName), 
                                   new OperandParameter(parameter1.Name), 
                                   BinaryOperatorType.Equal),
                new NotOperator(new InOperator(new OperandProperty(fieldYearName), 
                                               new ConstantValue[] { new ConstantValue(year2001),
                                                                     new ConstantValue(year2002) 
                                                                   })));

            pivot1.FilterString = filterCriteria.ToString();
            dashboardDesigner1.Dashboard = dashboard;
        }
    }
}
