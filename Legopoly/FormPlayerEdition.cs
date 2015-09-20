using Legopoly.Data;
using Legopoly.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legopoly
{
    public partial class FormPlayerEdition : Form
    {
        private Player player;

        public FormPlayerEdition()
        {
            InitializeComponent();
            this.player = new Player();
            InitializeFormContent();
        }

        public Player Player
        {
            get
            {
                return this.player;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void InitializeFormContent()
        {
            this.textBoxName.Text = this.player.Name;
            this.textBoxCapital.Text = this.player.Capital.ToString();
            this.numericUpDownCreativity.Value = Convert.ToDecimal(this.player.Experiences.Creativity);
            this.numericUpDownEmpathy.Value = Convert.ToDecimal(this.player.Experiences.Empathy);
            this.numericUpDownManagement.Value = Convert.ToDecimal(this.player.Experiences.ManagerialSkills);
            this.numericUpDownPhysicalFitness.Value = Convert.ToDecimal(this.player.Experiences.PhysicalFitness);
            this.numericUpDownScientific.Value = Convert.ToDecimal(this.player.Experiences.Scientific);

            this.labelMaxPoints.Text = string.Format(this.labelMaxPoints.Text, OptionsMain.Instance.DefaultExperiencePoints);
            ValidateOKButton();
        }

        private void numericUpDownScientific_ValueChanged(object sender, EventArgs e)
        {
            if (!ValidateExperiencePoints())
                this.numericUpDownScientific.Value--;

            this.player.Experiences.Scientific = Convert.ToInt32(this.numericUpDownScientific.Value);
            ValidateOKButton();
        }

        private void numericUpDownPhysicalFitness_ValueChanged(object sender, EventArgs e)
        {
            if (!ValidateExperiencePoints())
                this.numericUpDownPhysicalFitness.Value--;

            this.player.Experiences.PhysicalFitness = Convert.ToInt32(this.numericUpDownPhysicalFitness.Value);
            ValidateOKButton();
        }

        private void numericUpDownManagement_ValueChanged(object sender, EventArgs e)
        {
            if (!ValidateExperiencePoints())
                this.numericUpDownManagement.Value--;

            this.player.Experiences.ManagerialSkills = Convert.ToInt32(this.numericUpDownManagement.Value);
            ValidateOKButton();
        }

        private void numericUpDownCreativity_ValueChanged(object sender, EventArgs e)
        {
            if (!ValidateExperiencePoints())
                this.numericUpDownCreativity.Value--;

            this.player.Experiences.Creativity = Convert.ToInt32(this.numericUpDownCreativity.Value);
            ValidateOKButton();
        }

        private void numericUpDownEmpathy_ValueChanged(object sender, EventArgs e)
        {
            if (!ValidateExperiencePoints())
                this.numericUpDownEmpathy.Value--;

            this.player.Experiences.Empathy = Convert.ToInt32(this.numericUpDownEmpathy.Value);
            ValidateOKButton();
        }

        private void numericUpDownScientific_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private bool ValidateExperiencePoints()
        {
            return !(ComputeTotalExperiencePoints() > OptionsMain.Instance.DefaultExperiencePoints);
        }       

        private decimal ComputeTotalExperiencePoints()
        {
            return this.numericUpDownCreativity.Value +
                   this.numericUpDownEmpathy.Value +
                   this.numericUpDownManagement.Value +
                   this.numericUpDownPhysicalFitness.Value +
                   this.numericUpDownScientific.Value;
        }

        private void ValidateOKButton()
        {
            bool valide = true;

            if (string.IsNullOrWhiteSpace(this.textBoxName.Name) ||
                this.textBoxName.Name.Length < 3)
                valide = false;

            if (ComputeTotalExperiencePoints() < OptionsMain.Instance.DefaultExperiencePoints)
                valide = false;

            this.buttonOK.Enabled = valide;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ValidateOKButton();
        }
    }
}
