
namespace OlhaPasta
{
    partial class OlhaPastaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OlhaPastaForm));
            this.buttonCount = new System.Windows.Forms.Button();
            this.textBoxRootDirectory = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelRootDirectory = new System.Windows.Forms.Label();
            this.treeViewResult = new System.Windows.Forms.TreeView();
            this.checkBoxMaxLevel = new System.Windows.Forms.CheckBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxItemType = new System.Windows.Forms.CheckBox();
            this.labelMaxLevel = new System.Windows.Forms.Label();
            this.textBoxMaxLevel = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(258, 240);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(97, 37);
            this.buttonCount.TabIndex = 0;
            this.buttonCount.Text = "Contar";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // textBoxRootDirectory
            // 
            this.textBoxRootDirectory.Location = new System.Drawing.Point(11, 42);
            this.textBoxRootDirectory.Name = "textBoxRootDirectory";
            this.textBoxRootDirectory.Size = new System.Drawing.Size(332, 20);
            this.textBoxRootDirectory.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelRootDirectory);
            this.groupBox1.Controls.Add(this.textBoxRootDirectory);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // labelRootDirectory
            // 
            this.labelRootDirectory.AutoSize = true;
            this.labelRootDirectory.Location = new System.Drawing.Point(8, 26);
            this.labelRootDirectory.Name = "labelRootDirectory";
            this.labelRootDirectory.Size = new System.Drawing.Size(201, 13);
            this.labelRootDirectory.TabIndex = 2;
            this.labelRootDirectory.Text = "Caminho do diretório base para pesquisa:";
            // 
            // treeViewResult
            // 
            this.treeViewResult.Location = new System.Drawing.Point(12, 283);
            this.treeViewResult.Name = "treeViewResult";
            this.treeViewResult.Size = new System.Drawing.Size(360, 228);
            this.treeViewResult.TabIndex = 3;
            // 
            // checkBoxMaxLevel
            // 
            this.checkBoxMaxLevel.AutoSize = true;
            this.checkBoxMaxLevel.Location = new System.Drawing.Point(41, 62);
            this.checkBoxMaxLevel.Name = "checkBoxMaxLevel";
            this.checkBoxMaxLevel.Size = new System.Drawing.Size(162, 17);
            this.checkBoxMaxLevel.TabIndex = 3;
            this.checkBoxMaxLevel.Text = "Definir limite de profundidade";
            this.checkBoxMaxLevel.UseVisualStyleBackColor = true;
            this.checkBoxMaxLevel.CheckedChanged += new System.EventHandler(this.checkBoxMaxLevel_CheckedChanged);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.checkBoxItemType);
            this.groupBoxSettings.Controls.Add(this.labelMaxLevel);
            this.groupBoxSettings.Controls.Add(this.textBoxMaxLevel);
            this.groupBoxSettings.Controls.Add(this.checkBoxMaxLevel);
            this.groupBoxSettings.Location = new System.Drawing.Point(12, 101);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(360, 133);
            this.groupBoxSettings.TabIndex = 4;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Opções";
            // 
            // checkBoxItemType
            // 
            this.checkBoxItemType.AutoSize = true;
            this.checkBoxItemType.Location = new System.Drawing.Point(41, 28);
            this.checkBoxItemType.Name = "checkBoxItemType";
            this.checkBoxItemType.Size = new System.Drawing.Size(138, 17);
            this.checkBoxItemType.TabIndex = 6;
            this.checkBoxItemType.Text = "Contar apenas arquivos";
            this.checkBoxItemType.UseVisualStyleBackColor = true;
            // 
            // labelMaxLevel
            // 
            this.labelMaxLevel.AutoSize = true;
            this.labelMaxLevel.Location = new System.Drawing.Point(59, 94);
            this.labelMaxLevel.Name = "labelMaxLevel";
            this.labelMaxLevel.Size = new System.Drawing.Size(111, 13);
            this.labelMaxLevel.TabIndex = 5;
            this.labelMaxLevel.Text = "Profundidade máxima:";
            // 
            // textBoxMaxLevel
            // 
            this.textBoxMaxLevel.Location = new System.Drawing.Point(176, 91);
            this.textBoxMaxLevel.Name = "textBoxMaxLevel";
            this.textBoxMaxLevel.Size = new System.Drawing.Size(123, 20);
            this.textBoxMaxLevel.TabIndex = 4;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(23, 240);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(89, 37);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Limpar";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // OlhaPastaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(384, 523);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.treeViewResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OlhaPastaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olha Pasta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.TextBox textBoxRootDirectory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelRootDirectory;
        private System.Windows.Forms.TreeView treeViewResult;
        private System.Windows.Forms.CheckBox checkBoxMaxLevel;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.CheckBox checkBoxItemType;
        private System.Windows.Forms.Label labelMaxLevel;
        private System.Windows.Forms.TextBox textBoxMaxLevel;
        private System.Windows.Forms.Button buttonClear;
    }
}

