namespace TreeView1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvListOfAssets = new System.Windows.Forms.TreeView();
            this.btnTopDownExecute = new System.Windows.Forms.Button();
            this.btnBottomUpExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvListOfAssets
            // 
            this.tvListOfAssets.Location = new System.Drawing.Point(180, 85);
            this.tvListOfAssets.Name = "tvListOfAssets";
            this.tvListOfAssets.Size = new System.Drawing.Size(877, 1318);
            this.tvListOfAssets.TabIndex = 0;
            // 
            // btnTopDownExecute
            // 
            this.btnTopDownExecute.Location = new System.Drawing.Point(1518, 972);
            this.btnTopDownExecute.Name = "btnTopDownExecute";
            this.btnTopDownExecute.Size = new System.Drawing.Size(468, 148);
            this.btnTopDownExecute.TabIndex = 1;
            this.btnTopDownExecute.Text = "button1";
            this.btnTopDownExecute.UseVisualStyleBackColor = true;
            this.btnTopDownExecute.Click += new System.EventHandler(this.btnTopDownExecute_Click);
            // 
            // btnBottomUpExecute
            // 
            this.btnBottomUpExecute.Location = new System.Drawing.Point(1518, 1218);
            this.btnBottomUpExecute.Name = "btnBottomUpExecute";
            this.btnBottomUpExecute.Size = new System.Drawing.Size(449, 130);
            this.btnBottomUpExecute.TabIndex = 2;
            this.btnBottomUpExecute.Text = "button2";
            this.btnBottomUpExecute.UseVisualStyleBackColor = true;
            this.btnBottomUpExecute.Click += new System.EventHandler(this.btnBottomUpExecute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2293, 1592);
            this.Controls.Add(this.btnBottomUpExecute);
            this.Controls.Add(this.btnTopDownExecute);
            this.Controls.Add(this.tvListOfAssets);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvListOfAssets;
        private System.Windows.Forms.Button btnTopDownExecute;
        private System.Windows.Forms.Button btnBottomUpExecute;
    }
}

