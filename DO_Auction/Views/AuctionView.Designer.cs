namespace DO_Login.Views
{
    partial class AuctionView
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewBid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbYouBid = new System.Windows.Forms.Label();
            this.lbCurrentBid = new System.Windows.Forms.Label();
            this.lbHighest = new System.Windows.Forms.Label();
            this.cbOffers = new System.Windows.Forms.ComboBox();
            this.offerModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTimeBid = new System.Windows.Forms.TextBox();
            this.gvBids = new System.Windows.Forms.DataGridView();
            this.Offer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.youNewBidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LootId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label111 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSID = new System.Windows.Forms.TextBox();
            this.userModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbServer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCredits = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offerModelBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "You bid:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(70, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bid";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Highest:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "New bid:";
            // 
            // tbNewBid
            // 
            this.tbNewBid.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewBid.Location = new System.Drawing.Point(70, 38);
            this.tbNewBid.Name = "tbNewBid";
            this.tbNewBid.Size = new System.Drawing.Size(124, 22);
            this.tbNewBid.TabIndex = 7;
            this.tbNewBid.Text = "10000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current bid:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Time:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbYouBid);
            this.groupBox1.Controls.Add(this.lbCurrentBid);
            this.groupBox1.Controls.Add(this.lbHighest);
            this.groupBox1.Controls.Add(this.cbOffers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 135);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Offer";
            // 
            // lbYouBid
            // 
            this.lbYouBid.AutoSize = true;
            this.lbYouBid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYouBid.Location = new System.Drawing.Point(78, 111);
            this.lbYouBid.Name = "lbYouBid";
            this.lbYouBid.Size = new System.Drawing.Size(55, 17);
            this.lbYouBid.TabIndex = 19;
            this.lbYouBid.Text = "You bid:";
            // 
            // lbCurrentBid
            // 
            this.lbCurrentBid.AutoSize = true;
            this.lbCurrentBid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentBid.Location = new System.Drawing.Point(101, 83);
            this.lbCurrentBid.Name = "lbCurrentBid";
            this.lbCurrentBid.Size = new System.Drawing.Size(77, 17);
            this.lbCurrentBid.TabIndex = 18;
            this.lbCurrentBid.Text = "Current bid:";
            // 
            // lbHighest
            // 
            this.lbHighest.AutoSize = true;
            this.lbHighest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHighest.Location = new System.Drawing.Point(79, 56);
            this.lbHighest.Name = "lbHighest";
            this.lbHighest.Size = new System.Drawing.Size(55, 17);
            this.lbHighest.TabIndex = 17;
            this.lbHighest.Text = "Highest:";
            // 
            // cbOffers
            // 
            this.cbOffers.DataSource = this.offerModelBindingSource;
            this.cbOffers.DisplayMember = "name";
            this.cbOffers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOffers.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOffers.FormattingEnabled = true;
            this.cbOffers.Location = new System.Drawing.Point(16, 19);
            this.cbOffers.Name = "cbOffers";
            this.cbOffers.Size = new System.Drawing.Size(178, 21);
            this.cbOffers.TabIndex = 16;
            // 
            // offerModelBindingSource
            // 
            this.offerModelBindingSource.DataSource = typeof(DO_Login.Models.OfferModel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTimeBid);
            this.groupBox2.Controls.Add(this.tbNewBid);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(219, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 135);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "You Bid";
            // 
            // tbTimeBid
            // 
            this.tbTimeBid.Location = new System.Drawing.Point(70, 71);
            this.tbTimeBid.Name = "tbTimeBid";
            this.tbTimeBid.Size = new System.Drawing.Size(100, 20);
            this.tbTimeBid.TabIndex = 27;
            this.tbTimeBid.Text = "00:19:00";
            // 
            // gvBids
            // 
            this.gvBids.AllowUserToAddRows = false;
            this.gvBids.AllowUserToOrderColumns = true;
            this.gvBids.AutoGenerateColumns = false;
            this.gvBids.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvBids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBids.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Offer,
            this.youNewBidDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.LootId});
            this.gvBids.DataSource = this.bidModelBindingSource;
            this.gvBids.Location = new System.Drawing.Point(12, 153);
            this.gvBids.MultiSelect = false;
            this.gvBids.Name = "gvBids";
            this.gvBids.RowHeadersVisible = false;
            this.gvBids.Size = new System.Drawing.Size(407, 307);
            this.gvBids.TabIndex = 15;
            this.gvBids.Tag = "";
            // 
            // Offer
            // 
            this.Offer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Offer.DataPropertyName = "Offer";
            this.Offer.HeaderText = "Offer";
            this.Offer.Name = "Offer";
            // 
            // youNewBidDataGridViewTextBoxColumn
            // 
            this.youNewBidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.youNewBidDataGridViewTextBoxColumn.DataPropertyName = "YouNewBid";
            this.youNewBidDataGridViewTextBoxColumn.HeaderText = "YouNewBid";
            this.youNewBidDataGridViewTextBoxColumn.Name = "youNewBidDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // LootId
            // 
            this.LootId.DataPropertyName = "LootId";
            this.LootId.HeaderText = "LootId";
            this.LootId.Name = "LootId";
            // 
            // bidModelBindingSource
            // 
            this.bidModelBindingSource.DataSource = typeof(DO_Login.Models.BidModel);
            // 
            // Label111
            // 
            this.Label111.AutoSize = true;
            this.Label111.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label111.Location = new System.Drawing.Point(425, 12);
            this.Label111.Name = "Label111";
            this.Label111.Size = new System.Drawing.Size(68, 17);
            this.Label111.TabIndex = 20;
            this.Label111.Text = "User Info:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(425, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "SID:";
            // 
            // tbSID
            // 
            this.tbSID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSID.Location = new System.Drawing.Point(461, 30);
            this.tbSID.Name = "tbSID";
            this.tbSID.ReadOnly = true;
            this.tbSID.Size = new System.Drawing.Size(159, 22);
            this.tbSID.TabIndex = 15;
            // 
            // tbServer
            // 
            this.tbServer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServer.Location = new System.Drawing.Point(487, 87);
            this.tbServer.Name = "tbServer";
            this.tbServer.ReadOnly = true;
            this.tbServer.Size = new System.Drawing.Size(133, 22);
            this.tbServer.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "SERVER:";
            // 
            // tbCredits
            // 
            this.tbCredits.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCredits.Location = new System.Drawing.Point(491, 59);
            this.tbCredits.Name = "tbCredits";
            this.tbCredits.ReadOnly = true;
            this.tbCredits.Size = new System.Drawing.Size(129, 22);
            this.tbCredits.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(425, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "CREDITS:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(425, 153);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(43, 17);
            this.lbTime.TabIndex = 25;
            this.lbTime.Text = "Time:";
            // 
            // tbTime
            // 
            this.tbTime.AutoSize = true;
            this.tbTime.Location = new System.Drawing.Point(474, 156);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(49, 13);
            this.tbTime.TabIndex = 26;
            this.tbTime.Text = "00:19:00";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(545, 437);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AuctionView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.tbCredits);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Label111);
            this.Controls.Add(this.gvBids);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AuctionView";
            this.Size = new System.Drawing.Size(632, 472);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offerModelBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewBid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvBids;
        private System.Windows.Forms.ComboBox cbOffers;
        private System.Windows.Forms.BindingSource offerModelBindingSource;
        private System.Windows.Forms.Label lbYouBid;
        private System.Windows.Forms.Label lbCurrentBid;
        private System.Windows.Forms.Label lbHighest;
        private System.Windows.Forms.Label Label111;
        private System.Windows.Forms.BindingSource bidModelBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSID;
        private System.Windows.Forms.BindingSource userModelBindingSource;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCredits;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label tbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offer;
        private System.Windows.Forms.DataGridViewTextBoxColumn youNewBidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LootId;
        private System.Windows.Forms.TextBox tbTimeBid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}