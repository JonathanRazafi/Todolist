namespace Todolist
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.CategoryText = new System.Windows.Forms.TextBox();
            this.NewTask = new System.Windows.Forms.Button();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.ProgressText = new System.Windows.Forms.TextBox();
            this.StartdateText = new System.Windows.Forms.TextBox();
            this.DeadlineText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TaskToModify = new System.Windows.Forms.TextBox();
            this.DeleteTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryText
            // 
            this.CategoryText.Location = new System.Drawing.Point(204, 28);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(270, 31);
            this.CategoryText.TabIndex = 1;
            // 
            // NewTask
            // 
            this.NewTask.Location = new System.Drawing.Point(39, 289);
            this.NewTask.Name = "NewTask";
            this.NewTask.Size = new System.Drawing.Size(435, 44);
            this.NewTask.TabIndex = 0;
            this.NewTask.Text = "New Task";
            this.NewTask.UseVisualStyleBackColor = true;
            this.NewTask.Click += new System.EventHandler(this.button2_Click);
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(204, 79);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(270, 31);
            this.TitleText.TabIndex = 1;
            // 
            // ProgressText
            // 
            this.ProgressText.Location = new System.Drawing.Point(204, 232);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(270, 31);
            this.ProgressText.TabIndex = 1;
            // 
            // StartdateText
            // 
            this.StartdateText.Location = new System.Drawing.Point(204, 130);
            this.StartdateText.Name = "StartdateText";
            this.StartdateText.Size = new System.Drawing.Size(270, 31);
            this.StartdateText.TabIndex = 1;
            // 
            // DeadlineText
            // 
            this.DeadlineText.Location = new System.Drawing.Point(204, 181);
            this.DeadlineText.Name = "DeadlineText";
            this.DeadlineText.Size = new System.Drawing.Size(270, 31);
            this.DeadlineText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Deadline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Progress";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 605);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1298, 476);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "UpdateTask";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Selected task";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Category";
            // 
            // TaskToModify
            // 
            this.TaskToModify.Location = new System.Drawing.Point(645, 66);
            this.TaskToModify.Name = "TaskToModify";
            this.TaskToModify.ReadOnly = true;
            this.TaskToModify.Size = new System.Drawing.Size(270, 31);
            this.TaskToModify.TabIndex = 8;
            // 
            // DeleteTask
            // 
            this.DeleteTask.Location = new System.Drawing.Point(645, 171);
            this.DeleteTask.Name = "DeleteTask";
            this.DeleteTask.Size = new System.Drawing.Size(270, 44);
            this.DeleteTask.TabIndex = 9;
            this.DeleteTask.Text = "DeleteTask";
            this.DeleteTask.UseVisualStyleBackColor = true;
            this.DeleteTask.Click += new System.EventHandler(this.DeleteTask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 1081);
            this.Controls.Add(this.DeleteTask);
            this.Controls.Add(this.TaskToModify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProgressText);
            this.Controls.Add(this.DeadlineText);
            this.Controls.Add(this.StartdateText);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.CategoryText);
            this.Controls.Add(this.NewTask);
            this.Name = "Form1";
            this.Text = "TODOLIST";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CategoryText;
        private System.Windows.Forms.Button NewTask;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.TextBox ProgressText;
        private System.Windows.Forms.TextBox StartdateText;
        private System.Windows.Forms.TextBox DeadlineText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TaskToModify;
        private System.Windows.Forms.Button DeleteTask;
    }
}

