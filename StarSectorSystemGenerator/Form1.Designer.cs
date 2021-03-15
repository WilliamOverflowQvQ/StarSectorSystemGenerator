
namespace StarSectorSystemGenerator {
	partial class Form1 {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.lv_PlanetsListView = new System.Windows.Forms.ListView();
			this.ch_PlanetId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_PlanetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_PlanetFocus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_PlanetType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btn_AddPlanet = new System.Windows.Forms.Button();
			this.btn_RemovePlanet = new System.Windows.Forms.Button();
			this.btn_Update = new System.Windows.Forms.Button();
			this.cb_AutoUpdate = new System.Windows.Forms.CheckBox();
			this.tb_ResultString = new System.Windows.Forms.TextBox();
			this.btn_NewStarSystem = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_StarSystemName = new System.Windows.Forms.TextBox();
			this.lv_ReferencesListView = new System.Windows.Forms.ListView();
			this.ch_RefId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_RefName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btn_AddReference = new System.Windows.Forms.Button();
			this.btn_RemoveReference = new System.Windows.Forms.Button();
			this.pg_PlanetProperties = new System.Windows.Forms.PropertyGrid();
			this.SuspendLayout();
			// 
			// lv_PlanetsListView
			// 
			this.lv_PlanetsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_PlanetId,
            this.ch_PlanetName,
            this.ch_PlanetFocus,
            this.ch_PlanetType});
			this.lv_PlanetsListView.FullRowSelect = true;
			this.lv_PlanetsListView.GridLines = true;
			this.lv_PlanetsListView.HideSelection = false;
			this.lv_PlanetsListView.Location = new System.Drawing.Point(12, 12);
			this.lv_PlanetsListView.MultiSelect = false;
			this.lv_PlanetsListView.Name = "lv_PlanetsListView";
			this.lv_PlanetsListView.Size = new System.Drawing.Size(222, 202);
			this.lv_PlanetsListView.TabIndex = 0;
			this.lv_PlanetsListView.UseCompatibleStateImageBehavior = false;
			this.lv_PlanetsListView.View = System.Windows.Forms.View.Details;
			this.lv_PlanetsListView.SelectedIndexChanged += new System.EventHandler(this.lv_PlanetsListView_SelectedIndexChanged);
			// 
			// ch_PlanetId
			// 
			this.ch_PlanetId.Text = "Id";
			this.ch_PlanetId.Width = 30;
			// 
			// ch_PlanetName
			// 
			this.ch_PlanetName.Text = "Name";
			// 
			// ch_PlanetFocus
			// 
			this.ch_PlanetFocus.Text = "Focus";
			// 
			// ch_PlanetType
			// 
			this.ch_PlanetType.Text = "Type";
			// 
			// btn_AddPlanet
			// 
			this.btn_AddPlanet.Enabled = false;
			this.btn_AddPlanet.Location = new System.Drawing.Point(88, 220);
			this.btn_AddPlanet.Name = "btn_AddPlanet";
			this.btn_AddPlanet.Size = new System.Drawing.Size(70, 24);
			this.btn_AddPlanet.TabIndex = 1;
			this.btn_AddPlanet.Text = "Add";
			this.btn_AddPlanet.UseVisualStyleBackColor = true;
			this.btn_AddPlanet.Click += new System.EventHandler(this.btn_AddPlanet_Click);
			// 
			// btn_RemovePlanet
			// 
			this.btn_RemovePlanet.Enabled = false;
			this.btn_RemovePlanet.Location = new System.Drawing.Point(164, 220);
			this.btn_RemovePlanet.Name = "btn_RemovePlanet";
			this.btn_RemovePlanet.Size = new System.Drawing.Size(70, 24);
			this.btn_RemovePlanet.TabIndex = 2;
			this.btn_RemovePlanet.Text = "Remove";
			this.btn_RemovePlanet.UseVisualStyleBackColor = true;
			this.btn_RemovePlanet.Click += new System.EventHandler(this.btn_RemovePlanet_Click);
			// 
			// btn_Update
			// 
			this.btn_Update.Location = new System.Drawing.Point(240, 250);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(70, 24);
			this.btn_Update.TabIndex = 3;
			this.btn_Update.Text = "Update";
			this.btn_Update.UseVisualStyleBackColor = true;
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// cb_AutoUpdate
			// 
			this.cb_AutoUpdate.AutoSize = true;
			this.cb_AutoUpdate.Location = new System.Drawing.Point(316, 255);
			this.cb_AutoUpdate.Name = "cb_AutoUpdate";
			this.cb_AutoUpdate.Size = new System.Drawing.Size(84, 16);
			this.cb_AutoUpdate.TabIndex = 4;
			this.cb_AutoUpdate.Text = "AutoUpdate";
			this.cb_AutoUpdate.UseVisualStyleBackColor = true;
			// 
			// tb_ResultString
			// 
			this.tb_ResultString.Location = new System.Drawing.Point(465, 12);
			this.tb_ResultString.Multiline = true;
			this.tb_ResultString.Name = "tb_ResultString";
			this.tb_ResultString.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.tb_ResultString.Size = new System.Drawing.Size(207, 296);
			this.tb_ResultString.TabIndex = 6;
			// 
			// btn_NewStarSystem
			// 
			this.btn_NewStarSystem.Location = new System.Drawing.Point(12, 220);
			this.btn_NewStarSystem.Name = "btn_NewStarSystem";
			this.btn_NewStarSystem.Size = new System.Drawing.Size(70, 24);
			this.btn_NewStarSystem.TabIndex = 7;
			this.btn_NewStarSystem.Text = "New SS";
			this.btn_NewStarSystem.UseVisualStyleBackColor = true;
			this.btn_NewStarSystem.Click += new System.EventHandler(this.btn_NewStarSystem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 253);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 12);
			this.label1.TabIndex = 8;
			this.label1.Text = "Star System Name";
			// 
			// tb_StarSystemName
			// 
			this.tb_StarSystemName.Location = new System.Drawing.Point(122, 250);
			this.tb_StarSystemName.Name = "tb_StarSystemName";
			this.tb_StarSystemName.Size = new System.Drawing.Size(112, 21);
			this.tb_StarSystemName.TabIndex = 10;
			// 
			// lv_ReferencesListView
			// 
			this.lv_ReferencesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_RefId,
            this.ch_RefName});
			this.lv_ReferencesListView.FullRowSelect = true;
			this.lv_ReferencesListView.GridLines = true;
			this.lv_ReferencesListView.HideSelection = false;
			this.lv_ReferencesListView.Location = new System.Drawing.Point(12, 277);
			this.lv_ReferencesListView.Name = "lv_ReferencesListView";
			this.lv_ReferencesListView.Size = new System.Drawing.Size(222, 148);
			this.lv_ReferencesListView.TabIndex = 11;
			this.lv_ReferencesListView.UseCompatibleStateImageBehavior = false;
			this.lv_ReferencesListView.View = System.Windows.Forms.View.Details;
			// 
			// ch_RefId
			// 
			this.ch_RefId.Text = "Id";
			// 
			// ch_RefName
			// 
			this.ch_RefName.Text = "Name";
			// 
			// btn_AddReference
			// 
			this.btn_AddReference.Enabled = false;
			this.btn_AddReference.Location = new System.Drawing.Point(88, 431);
			this.btn_AddReference.Name = "btn_AddReference";
			this.btn_AddReference.Size = new System.Drawing.Size(70, 24);
			this.btn_AddReference.TabIndex = 12;
			this.btn_AddReference.Text = "Add";
			this.btn_AddReference.UseVisualStyleBackColor = true;
			this.btn_AddReference.Click += new System.EventHandler(this.btn_AddReference_Click);
			// 
			// btn_RemoveReference
			// 
			this.btn_RemoveReference.Location = new System.Drawing.Point(164, 431);
			this.btn_RemoveReference.Name = "btn_RemoveReference";
			this.btn_RemoveReference.Size = new System.Drawing.Size(70, 24);
			this.btn_RemoveReference.TabIndex = 13;
			this.btn_RemoveReference.Text = "Remove";
			this.btn_RemoveReference.UseVisualStyleBackColor = true;
			// 
			// pg_PlanetProperties
			// 
			this.pg_PlanetProperties.Location = new System.Drawing.Point(240, 12);
			this.pg_PlanetProperties.Name = "pg_PlanetProperties";
			this.pg_PlanetProperties.Size = new System.Drawing.Size(219, 232);
			this.pg_PlanetProperties.TabIndex = 15;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.pg_PlanetProperties);
			this.Controls.Add(this.btn_RemoveReference);
			this.Controls.Add(this.btn_AddReference);
			this.Controls.Add(this.lv_ReferencesListView);
			this.Controls.Add(this.tb_StarSystemName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_NewStarSystem);
			this.Controls.Add(this.tb_ResultString);
			this.Controls.Add(this.cb_AutoUpdate);
			this.Controls.Add(this.btn_Update);
			this.Controls.Add(this.btn_RemovePlanet);
			this.Controls.Add(this.btn_AddPlanet);
			this.Controls.Add(this.lv_PlanetsListView);
			this.Name = "Form1";
			this.Text = "Star System Editor (v0.1)";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lv_PlanetsListView;
		private System.Windows.Forms.ColumnHeader ch_PlanetId;
		private System.Windows.Forms.ColumnHeader ch_PlanetName;
		private System.Windows.Forms.ColumnHeader ch_PlanetFocus;
		private System.Windows.Forms.ColumnHeader ch_PlanetType;
		private System.Windows.Forms.Button btn_AddPlanet;
		private System.Windows.Forms.Button btn_RemovePlanet;
		private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.CheckBox cb_AutoUpdate;
		private System.Windows.Forms.TextBox tb_ResultString;
		private System.Windows.Forms.Button btn_NewStarSystem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_StarSystemName;
		private System.Windows.Forms.ListView lv_ReferencesListView;
		private System.Windows.Forms.Button btn_AddReference;
		private System.Windows.Forms.Button btn_RemoveReference;
		private System.Windows.Forms.ColumnHeader ch_RefId;
		private System.Windows.Forms.ColumnHeader ch_RefName;
		private System.Windows.Forms.PropertyGrid pg_PlanetProperties;
	}
}

