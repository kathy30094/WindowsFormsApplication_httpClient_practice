namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.change = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.showAll = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.listShowAll = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(280, 61);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 0;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            //
            //change
            //
            this.change.Location = new System.Drawing.Point(380, 61);
            this.change.Name = "change";
            this.change.Size = new  System.Drawing.Size(75, 23);
            this.change.TabIndex = 0;
            this.change.Text = "change";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);


            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(483, 61);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 1;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(180, 61);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 2;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(389, 104);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(170, 23);
            this.showAll.TabIndex = 3;
            this.showAll.Text = "show all";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(233, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 5;
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(404, 21);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(100, 22);
            this.sex.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(50, 22);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 22);
            this.ID.TabIndex = 4;
            // 
            // listShowAll
            // 
            this.listShowAll.FormattingEnabled = true;
            this.listShowAll.ItemHeight = 12;
            this.listShowAll.Location = new System.Drawing.Point(13, 147);
            this.listShowAll.Name = "listShowAll";
            this.listShowAll.Size = new System.Drawing.Size(546, 364);
            this.listShowAll.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name :  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sex :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 624);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listShowAll);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.name);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.search);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Controls.Add(this.change);
        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.ListBox listShowAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button change;
    }
}

