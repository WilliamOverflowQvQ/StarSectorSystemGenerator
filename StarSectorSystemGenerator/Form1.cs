using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using static StarSectorSystemGenerator.StarSystemController;

namespace StarSectorSystemGenerator {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();

			StarSystemController.init("");
		}
		public void DebugGrammarLab() {
		}

		private void btn_AddPlanet_Click(object sender, EventArgs e) {
			MyPlanetAPI myPlanetAPI = new MyPlanetAPI(
				StarSystemController.myStarSystemAPI.Name + lv_PlanetsListView.Items.Count);
			MyPlanetAPILVItem myPlanetLVItem = new MyPlanetAPILVItem(myPlanetAPI);
			lv_PlanetsListView.Items.Add(myPlanetLVItem);
		}

		private void btn_AddReference_Click(object sender, EventArgs e) {
			MyPlanetRef myPlanetRef = new MyPlanetRef(
				StarSystemController.myStarSystemAPI.Name + "Ref" +
				lv_ReferencesListView.Items.Count);
			MyPlanetRefLVItem myPlanetRefLVItem = new MyPlanetRefLVItem(myPlanetRef);
			lv_ReferencesListView.Items.Add(myPlanetRefLVItem);
		}

		private void updatePlanetsLV() {
			MyPlanetAPI myPlanetAPI = new MyPlanetAPI("Qades I");
			myPlanetAPI.Focus = "Qades";
			myPlanetAPI.OrbitDays = 30;
			myPlanetAPI.OrbitRadius = 1000;
			myPlanetAPI.Radius = 90;

			MyStarSystemAPI myStarSystemAPI = new MyStarSystemAPI("Qades");

			StringBuilder sb = new StringBuilder(2048);
			sb.Append("RunCode ");
			sb.AppendLine(myStarSystemAPI.AssignStarSystemStringLine());
			sb.AppendLine(myStarSystemAPI.AssignPlanetGeneratorStringLine(myPlanetAPI));

			tb_ResultString.Text = sb.ToString();
		}

		private void btn_NewStarSystem_Click(object sender, EventArgs e) {
			StarSystemController.init(tb_StarSystemName.Text);

			//Cannot edit star system without system name
			btn_AddPlanet.Enabled = true;
			btn_AddReference.Enabled = true;
		}

		private void lv_PlanetsListView_SelectedIndexChanged(object sender, EventArgs e) {
			if (lv_PlanetsListView.Items.Count == 0)
				return;
			if (lv_PlanetsListView.SelectedItems.Count == 0) {
				btn_RemovePlanet.Enabled = false;
				return;
			}
			btn_RemovePlanet.Enabled = true;
			MyPlanetAPILVItem selected =
				lv_PlanetsListView.SelectedItems[0] as MyPlanetAPILVItem;
			pg_PlanetProperties.SelectedObject = selected.thisPlanetAPI;
		}

		private void btn_Update_Click(object sender, EventArgs e) {
			//Update PlanetsLV
			//todo...
			
			StringBuilder sb = new StringBuilder();
			sb.Append("RunCode ");											//Header
			sb.AppendLine(myStarSystemAPI.AssignStarSystemStringLine());    //Star System
			sb.AppendLine(myStarSystemAPI.AssignCenterStarStringLine());    //Center Star

			//Get planet refs
			foreach (MyPlanetRefLVItem ilvi in lv_ReferencesListView.Items)
				sb.AppendLine(myStarSystemAPI.DefinePlanetReferenceStringLine(ilvi.thisPlanetRef));
			sb.AppendLine(myStarSystemAPI.GetPlanetRefsLoopHead());         //Use loop to assign all the PlanetAPIs
			foreach (MyPlanetRefLVItem ilvi in lv_ReferencesListView.Items)
				sb.AppendLine(myStarSystemAPI.AssignPlanetRefStringLine(ilvi.thisPlanetRef));
			sb.AppendLine(myStarSystemAPI.GetPlanetRefsLoopTail());

			//Add planets
			foreach (MyPlanetAPILVItem ilvi in lv_PlanetsListView.Items)
				sb.AppendLine(myStarSystemAPI.AssignPlanetGeneratorStringLine(
					ilvi.thisPlanetAPI));
			
			tb_ResultString.Text = sb.ToString();							//Submit
		}

		private void btn_RemovePlanet_Click(object sender, EventArgs e) {
			lv_PlanetsListView.SelectedItems[0].Remove();
			pg_PlanetProperties.SelectedObject = null;
		}

		private void pg_PlanetProperties_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
			foreach (MyPlanetAPILVItem ilvi in lv_PlanetsListView.Items) {
				ilvi.SubItems[1].Text = ilvi.thisPlanetAPI.Name;
				ilvi.SubItems[2].Text = ilvi.thisPlanetAPI.Focus;
				ilvi.SubItems[3].Text = ilvi.thisPlanetAPI.Type;
			}
			foreach(MyPlanetRefLVItem ilvi in lv_ReferencesListView.Items) {
				ilvi.SubItems[1].Text = ilvi.thisPlanetRef.Name;
			}
		}

		private void lv_ReferencesListView_SelectedIndexChanged(object sender, EventArgs e) {
			if (lv_ReferencesListView.Items.Count == 0)
				return;
			if (lv_ReferencesListView.SelectedItems.Count == 0) {
				btn_AddReference.Enabled = false;
				return;
			}
			btn_AddReference.Enabled = true;
			MyPlanetRefLVItem selected =
				lv_ReferencesListView.SelectedItems[0] as MyPlanetRefLVItem;
			pg_PlanetProperties.SelectedObject = selected.thisPlanetRef;
		}
	}

	public static class StarSystemController {
		public static MyStarSystemAPI myStarSystemAPI;
		
		public static void init(string starSystemName) {
			myStarSystemAPI = new MyStarSystemAPI(starSystemName);
		}

		//得到空格替换为下划线的java内用变量名
		public static string GetVarName(string name) {
			return name.Replace(' ', '_');
		}

		public static string GetVarNameP(string name) {
			return "p_" + name.Replace(' ', '_');
		}

		public static string GetQuoteName(string name) {
			return "\"" + name + "\"";
		}

		public class MyPlanetAPILVItem : ListViewItem {
			public MyPlanetAPI thisPlanetAPI;

			public MyPlanetAPILVItem(MyPlanetAPI planetAPI) {
				thisPlanetAPI = planetAPI;
				this.SubItems.Add(thisPlanetAPI.Name);
				this.SubItems.Add(thisPlanetAPI.Focus);
				this.SubItems.Add(thisPlanetAPI.Type);
			}
		}

		public class MyPlanetRefLVItem : ListViewItem {
			public MyPlanetRef thisPlanetRef;

			public MyPlanetRefLVItem(MyPlanetRef planetRef) {
				thisPlanetRef = planetRef;
				this.SubItems.Add(thisPlanetRef.Name);
			}
		}

		public class MyStarSystemAPI {
			public string Name;
			public string StarSystemVarName = "system";

			public MyStarSystemAPI(string name) {
				Name = name;
			}

			public string GetStarSystemString() {
				return "((StarSystemAPI)Global.getSector().getStarSystem(\"" + Name + "\"))";
			}

			public string GetCenterStarString() {
				return "((PlanetAPI)" + GetStarSystemString() + ".getStar())";
			}

			public string AssignStarSystemStringLine() {
				return "StarSystemAPI " + GetVarName(StarSystemVarName) + " = " +
					GetStarSystemString() + ";";
			}

			public string AssignCenterStarStringLine() {
				return "PlanetAPI " + GetVarNameP(Name) + " = " +
					GetCenterStarString() + ";";
			}

			public string AssignPlanetGeneratorStringLine(MyPlanetAPI planet) {
				if (planet.Focus == "")
					planet.Focus = Name;
				return "PlanetAPI " + GetVarNameP(planet.Name) + " = " +
					GetVarName(StarSystemVarName) + ".addPlanet(" +
					GetQuoteName(planet.Name) + ", " +
					GetVarNameP(planet.Focus) + ", " +
					GetQuoteName(planet.Name) + ", " +
					GetQuoteName(planet.Type) + ", " +
					planet.Angle + ", " +
					planet.Radius + ", " +
					planet.OrbitRadius + ", " +
					planet.OrbitDays + ");";
			}

			public string DefinePlanetReferenceStringLine(MyPlanetRef planet) {
				if (planet.Name == "")
					return "";
				return "PlanetAPI " + GetVarNameP(planet.Name) + " = " +
					"null;";
			}

			public string GetPlanetRefsLoopHead() {
				return "foreach (PlanetAPI ipapi : " + GetVarName(StarSystemVarName) + ".getPlanets())" +
					" {";
			}

			public string GetPlanetRefsLoopTail() {
				return "}";
			}

			public string AssignPlanetRefStringLine(MyPlanetRef planet) {
				return "if(((PlanetAPI)ipapi).getName() == " + GetQuoteName(planet.Name) + ")" +
					GetVarNameP(planet.Name) + " = " + "(PlanetAPI)ipapi;";
			}


		}

		public class MyPlanetAPI {
			public string Name { get; set; }         //行星名（大多数情况也是id）
			public string Type { get; set; }         //行星类型，默认：jungle
			public string Focus { get; set; }        //公转对象，Java内用SectorEntityToken（常用PlanetAPI）
			public float Angle { get; set; }         //创建时的公转角度
			public float Radius { get; set; }        //行星大小（半径）
			public float OrbitRadius { get; set; }   //公转半径
			public float OrbitDays { get; set; }     //轨道周期

			public MyPlanetAPI(string name) {
				Name = name;
				Type = "jungle";
				Focus = "";
				Angle = 0f;
				Radius = 0f;
				OrbitRadius = 0f;
				OrbitDays = 1f;
			}


			//StarSystemAPI : LocationAPI
			//PlanetAPI	addPlanet(java.lang.String id,
			//SectorEntityToken focus,
			//java.lang.String name,
			//java.lang.String type,
			//float angle,
			//float radius,
			//float orbitRadius,
			//float orbitDays)
		}

		//可以使用已经存在的行星作为公转对象，用这个进行提前声明
		public class MyPlanetRef {
			public string Name { get; set; }
			public MyPlanetRef(string name) {
				Name = name;
			}
		}
	}



	
}
