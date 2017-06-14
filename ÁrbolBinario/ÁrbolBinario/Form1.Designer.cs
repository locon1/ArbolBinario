namespace ÁrbolBinario
{
    partial class Form1
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
            if (disposing && (components != null)) {
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblPrint = new System.Windows.Forms.Label();
            this.cmdPre = new System.Windows.Forms.Button();
            this.cmdIn = new System.Windows.Forms.Button();
            this.cmdPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(12, 34);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(142, 20);
            this.txtNum.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(98, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Ingrese un número:";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(79, 60);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 30);
            this.cmdAdd.TabIndex = 1;
            this.cmdAdd.Text = "Agregar";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(230, 12);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLista.Size = new System.Drawing.Size(230, 302);
            this.txtLista.TabIndex = 7;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(79, 167);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 3;
            this.cmdSearch.Text = "Buscar";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(9, 113);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(171, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Ingrese el nodo que quiere buscar:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 141);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(142, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrint.Location = new System.Drawing.Point(76, 223);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(61, 18);
            this.lblPrint.TabIndex = 7;
            this.lblPrint.Text = "Imprimir";
            // 
            // cmdPre
            // 
            this.cmdPre.Location = new System.Drawing.Point(12, 266);
            this.cmdPre.Name = "cmdPre";
            this.cmdPre.Size = new System.Drawing.Size(59, 23);
            this.cmdPre.TabIndex = 4;
            this.cmdPre.Text = "Preorden";
            this.cmdPre.UseVisualStyleBackColor = true;
            this.cmdPre.Click += new System.EventHandler(this.cmdPre_Click);
            // 
            // cmdIn
            // 
            this.cmdIn.Location = new System.Drawing.Point(79, 266);
            this.cmdIn.Name = "cmdIn";
            this.cmdIn.Size = new System.Drawing.Size(51, 23);
            this.cmdIn.TabIndex = 5;
            this.cmdIn.Text = "Inorden";
            this.cmdIn.UseVisualStyleBackColor = true;
            this.cmdIn.Click += new System.EventHandler(this.cmdIn_Click);
            // 
            // cmdPost
            // 
            this.cmdPost.Location = new System.Drawing.Point(136, 266);
            this.cmdPost.Name = "cmdPost";
            this.cmdPost.Size = new System.Drawing.Size(75, 23);
            this.cmdPost.TabIndex = 6;
            this.cmdPost.Text = "Postorden";
            this.cmdPost.UseVisualStyleBackColor = true;
            this.cmdPost.Click += new System.EventHandler(this.cmdPost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 326);
            this.Controls.Add(this.cmdPost);
            this.Controls.Add(this.cmdIn);
            this.Controls.Add(this.cmdPre);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.Button cmdPre;
        private System.Windows.Forms.Button cmdIn;
        private System.Windows.Forms.Button cmdPost;
    }
}

