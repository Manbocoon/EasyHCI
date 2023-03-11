
namespace EasyHCI.Forms
{
    partial class ProcessListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessListForm));
            this.list = new System.Windows.Forms.ListView();
            this.Column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addToExceptions = new System.Windows.Forms.Button();
            this.describ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.CheckBoxes = true;
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column1});
            this.list.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.list.FullRowSelect = true;
            this.list.GridLines = true;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(12, 98);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(533, 456);
            this.list.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list.TabIndex = 60;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_MouseClick);
            // 
            // Column1
            // 
            this.Column1.Text = "이름";
            this.Column1.Width = 250;
            // 
            // addToExceptions
            // 
            this.addToExceptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.addToExceptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToExceptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(20)))));
            this.addToExceptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.addToExceptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.addToExceptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToExceptions.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addToExceptions.ForeColor = System.Drawing.Color.White;
            this.addToExceptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addToExceptions.Location = new System.Drawing.Point(12, 560);
            this.addToExceptions.Name = "addToExceptions";
            this.addToExceptions.Size = new System.Drawing.Size(533, 48);
            this.addToExceptions.TabIndex = 66;
            this.addToExceptions.Text = "예외 목록에 추가";
            this.addToExceptions.UseVisualStyleBackColor = false;
            this.addToExceptions.Click += new System.EventHandler(this.addToExceptions_Click);
            // 
            // describ
            // 
            this.describ.AutoSize = true;
            this.describ.BackColor = System.Drawing.Color.Transparent;
            this.describ.Location = new System.Drawing.Point(12, 77);
            this.describ.Name = "describ";
            this.describ.Size = new System.Drawing.Size(333, 12);
            this.describ.TabIndex = 67;
            this.describ.Text = "메모리를 정리할 때 종료당하지 않을 프로세스를 선택하세요.";
            // 
            // ProcessListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 615);
            this.Controls.Add(this.describ);
            this.Controls.Add(this.addToExceptions);
            this.Controls.Add(this.list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcessListForm";
            this.Text = "Select Processes";
            this.Load += new System.EventHandler(this.ProcessListForm_Load);
            this.Resize += new System.EventHandler(this.ProcessListForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListView list;
        internal System.Windows.Forms.ColumnHeader Column1;
        private System.Windows.Forms.Button addToExceptions;
        private System.Windows.Forms.Label describ;
    }
}