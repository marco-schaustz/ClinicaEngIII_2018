﻿namespace ClinicaEngIII
{
    partial class FRM_ConsultaMateriais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ConsultaMateriais));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PBVoltar = new System.Windows.Forms.PictureBox();
            this.DGV_ConsultaMateriais = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PBVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ConsultaMateriais)).BeginInit();
            this.SuspendLayout();
            // 
            // PBVoltar
            // 
            this.PBVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBVoltar.BackgroundImage")));
            this.PBVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBVoltar.Location = new System.Drawing.Point(257, 233);
            this.PBVoltar.Name = "PBVoltar";
            this.PBVoltar.Size = new System.Drawing.Size(30, 30);
            this.PBVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBVoltar.TabIndex = 44;
            this.PBVoltar.TabStop = false;
            this.PBVoltar.Click += new System.EventHandler(this.PBVoltar_Click);
            // 
            // DGV_ConsultaMateriais
            // 
            this.DGV_ConsultaMateriais.AllowUserToOrderColumns = true;
            this.DGV_ConsultaMateriais.BackgroundColor = System.Drawing.Color.White;
            this.DGV_ConsultaMateriais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_ConsultaMateriais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_ConsultaMateriais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ConsultaMateriais.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_ConsultaMateriais.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGV_ConsultaMateriais.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.DGV_ConsultaMateriais.Location = new System.Drawing.Point(43, 38);
            this.DGV_ConsultaMateriais.Name = "DGV_ConsultaMateriais";
            this.DGV_ConsultaMateriais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_ConsultaMateriais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ConsultaMateriais.Size = new System.Drawing.Size(244, 189);
            this.DGV_ConsultaMateriais.TabIndex = 43;
            this.DGV_ConsultaMateriais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ConsultaMateriais_CellContentClick);
            // 
            // FRM_ConsultaMateriais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(327, 295);
            this.ControlBox = false;
            this.Controls.Add(this.PBVoltar);
            this.Controls.Add(this.DGV_ConsultaMateriais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_ConsultaMateriais";
            this.Text = "Consulta Materiais";
            this.Load += new System.EventHandler(this.FRM_ConsultaMateriais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ConsultaMateriais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBVoltar;
        private System.Windows.Forms.DataGridView DGV_ConsultaMateriais;
    }
}