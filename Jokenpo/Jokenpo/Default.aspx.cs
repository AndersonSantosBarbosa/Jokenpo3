using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jokenpo
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonJogar_Click(object sender, EventArgs e)
        {

            Response.Cookies["NomedoJogador1"].Value = TextBoxNomeJogador1.Text.ToString();
            Response.Cookies["NomedoJogador2"].Value = TextBoxNomeJogador2.Text.ToString();

            PanelCadastro.Visible = false;
            PanelJogo.Visible = true;

            LabelNomeJogador1.Text = TextBoxNomeJogador1.Text.ToString();
            LabelNomeJogador2.Text = TextBoxNomeJogador2.Text.ToString();
        }

        protected void ButtonResultado_Click(object sender, EventArgs e)
        {

            if (RadioButtonListJogador1.SelectedValue == RadioButtonListJogador2.SelectedValue)
            {
                LabelResultado.Text = "Empate";
            }
            else
            {

                    if (RadioButtonListJogador1.SelectedValue == "Papel" && RadioButtonListJogador2.SelectedValue == "Pedra")
                    {
                        LabelResultado.Text = "Jogador 1 " + LabelNomeJogador1.Text + " Vencedor";
                    }

                    if (RadioButtonListJogador1.SelectedValue == "Tesoura" && RadioButtonListJogador2.SelectedValue == "Papel")
                    {
                        LabelResultado.Text = "Jogador 1 " + LabelNomeJogador1.Text + " Vencedor";
                    }

                    if (RadioButtonListJogador1.SelectedValue == "Pedra" && RadioButtonListJogador2.SelectedValue == "Tesoura")
                    {
                        LabelResultado.Text = "Jogador 1 " + LabelNomeJogador1.Text + " Vencedor";
                    }

                    ////////////////////////////////////


                    if (RadioButtonListJogador2.SelectedValue == "Papel" && RadioButtonListJogador1.SelectedValue == "Pedra")
                    {
                        LabelResultado.Text = "Jogador 2 " + LabelNomeJogador2.Text + " Vencedor";
                    }

                    if (RadioButtonListJogador2.SelectedValue == "Tesoura" && RadioButtonListJogador1.SelectedValue == "Papel")
                    {
                        LabelResultado.Text = "Jogador 2 " + LabelNomeJogador2.Text + " Vencedor";
                    }

                    if (RadioButtonListJogador2.SelectedValue == "Pedra" && RadioButtonListJogador1.SelectedValue == "Tesoura")
                    {
                        LabelResultado.Text = "Jogador 2 " + LabelNomeJogador2.Text + " Vencedor";
                    }


            }

        }
    }
}