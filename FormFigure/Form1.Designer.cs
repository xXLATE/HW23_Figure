
namespace FormFigure
{
    partial class DarkPaint
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlPanel = new System.Windows.Forms.GroupBox();
            this.chooseColorBtn = new System.Windows.Forms.Button();
            this.thickBar = new System.Windows.Forms.TrackBar();
            this.clearBtn = new System.Windows.Forms.Button();
            this.figurePanel = new System.Windows.Forms.GroupBox();
            this.triangleBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.rectangleBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thickBar)).BeginInit();
            this.figurePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.controlPanel.Controls.Add(this.chooseColorBtn);
            this.controlPanel.Controls.Add(this.thickBar);
            this.controlPanel.Controls.Add(this.clearBtn);
            this.controlPanel.Controls.Add(this.figurePanel);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(800, 99);
            this.controlPanel.TabIndex = 0;
            this.controlPanel.TabStop = false;
            this.controlPanel.Enter += new System.EventHandler(this.controlPanel_Enter);
            // 
            // chooseColorBtn
            // 
            this.chooseColorBtn.Location = new System.Drawing.Point(571, 27);
            this.chooseColorBtn.Name = "chooseColorBtn";
            this.chooseColorBtn.Size = new System.Drawing.Size(75, 23);
            this.chooseColorBtn.TabIndex = 3;
            this.chooseColorBtn.UseVisualStyleBackColor = true;
            this.chooseColorBtn.Click += new System.EventHandler(this.chooseColorBtn_Click);
            // 
            // thickBar
            // 
            this.thickBar.Location = new System.Drawing.Point(431, 27);
            this.thickBar.Minimum = 1;
            this.thickBar.Name = "thickBar";
            this.thickBar.Size = new System.Drawing.Size(104, 45);
            this.thickBar.TabIndex = 2;
            this.thickBar.Value = 1;
            this.thickBar.Scroll += new System.EventHandler(this.thickBar_Scroll);
            // 
            // clearBtn
            // 
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearBtn.Location = new System.Drawing.Point(337, 27);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // figurePanel
            // 
            this.figurePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.figurePanel.Controls.Add(this.triangleBtn);
            this.figurePanel.Controls.Add(this.circleBtn);
            this.figurePanel.Controls.Add(this.rectangleBtn);
            this.figurePanel.Controls.Add(this.lineBtn);
            this.figurePanel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.figurePanel.Location = new System.Drawing.Point(6, 12);
            this.figurePanel.Name = "figurePanel";
            this.figurePanel.Size = new System.Drawing.Size(311, 81);
            this.figurePanel.TabIndex = 0;
            this.figurePanel.TabStop = false;
            this.figurePanel.Text = "Figures";
            // 
            // triangleBtn
            // 
            this.triangleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.triangleBtn.Image = global::FormFigure.Properties.Resources.triangle;
            this.triangleBtn.Location = new System.Drawing.Point(237, 15);
            this.triangleBtn.Name = "triangleBtn";
            this.triangleBtn.Size = new System.Drawing.Size(60, 60);
            this.triangleBtn.TabIndex = 3;
            this.triangleBtn.UseVisualStyleBackColor = true;
            this.triangleBtn.Click += new System.EventHandler(this.triangleBtn_Click);
            // 
            // circleBtn
            // 
            this.circleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.circleBtn.Image = global::FormFigure.Properties.Resources.circle;
            this.circleBtn.Location = new System.Drawing.Point(160, 15);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(60, 60);
            this.circleBtn.TabIndex = 2;
            this.circleBtn.UseVisualStyleBackColor = true;
            this.circleBtn.Click += new System.EventHandler(this.circleBtn_Click);
            // 
            // rectangleBtn
            // 
            this.rectangleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rectangleBtn.Image = global::FormFigure.Properties.Resources.rectangle;
            this.rectangleBtn.Location = new System.Drawing.Point(83, 15);
            this.rectangleBtn.Name = "rectangleBtn";
            this.rectangleBtn.Size = new System.Drawing.Size(60, 60);
            this.rectangleBtn.TabIndex = 1;
            this.rectangleBtn.UseVisualStyleBackColor = true;
            this.rectangleBtn.Click += new System.EventHandler(this.rectangleBtn_Click);
            // 
            // lineBtn
            // 
            this.lineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lineBtn.Image = global::FormFigure.Properties.Resources.line;
            this.lineBtn.Location = new System.Drawing.Point(8, 15);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(60, 60);
            this.lineBtn.TabIndex = 0;
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Desktop;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 99);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(800, 351);
            this.canvas.TabIndex = 1;
            // 
            // DarkPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.controlPanel);
            this.Name = "DarkPaint";
            this.Text = "Dark Paint";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thickBar)).EndInit();
            this.figurePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlPanel;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.GroupBox figurePanel;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button triangleBtn;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.Button rectangleBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TrackBar thickBar;
        private System.Windows.Forms.Button chooseColorBtn;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

