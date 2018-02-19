using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Web;
using System.Text;
using System.Data;
using FGlobus.Componentes.WinForms;
using FGlobus.Util.ExtensaoObject;
using FGlobus.Util.ExtensaoEnum;
using DevExpress.XtraEditors.Controls;


/// <summary>
/// 
/// </summary>
namespace WFA_Workflow.AssociacaoBGM
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("xxxxxxxxxxxxxx = {Teste}")]
    public partial class FrmAssociacaoBGM3 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmAssociacaoBGM3"/> class.
        /// </summary> 
        public FrmAssociacaoBGM3()
        {
            InitializeComponent();
        }


        private void XISTO()
        {
            string aa = ExtensaoObject.RetornarName<Veiculo>(p => p.Empresa);
            Console.Write(aa);

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            associacaoBGM1.MotivoCondicaoItemAssociado = String.Format(associacaoBGM1.MotivoCondicaoItemAssociado, cmbBxEdtTipo.EditValue);

            associacaoBGM1.PopularDisponiveis(
                listaVeiculo,
                listaVeiculo
                    .Where(w => w.Condicao == cmbBxEdtTipo.RetornarItem<eCondicao>()));


            //associacaoBGM1.RetornarAssociados<Veiculo,int>(p=> p.Empresa)
            //associacaoBGM1
            //    .xxxxxxx<Veiculo>()

            //associacaoBGM1["MyEnum",false].Caption
        }

        List<Veiculo> listaVeiculo = new List<Veiculo>();

        private void FrmAssociacaoBGM3_Shown(object sender, EventArgs e)
        {
            listaVeiculo.Add(new Veiculo() { Empresa = 1, Filial = 1, Garagem = 1, Placa = "AAA-0000", Prefixo = "0000001", Condicao = eCondicao.Ativo, MyEnum = MyEnum.a1 });
            listaVeiculo.Add(new Veiculo() { Empresa = 1, Filial = 1, Garagem = 1, Placa = "BBB-0000", Prefixo = "0000002", Condicao = eCondicao.Inativo, MyEnum = MyEnum.a2 });
            listaVeiculo.Add(new Veiculo() { Empresa = 1, Filial = 1, Garagem = 1, Placa = "CCC-0000", Prefixo = "0000003", Condicao = eCondicao.Inativo, MyEnum = MyEnum.b1 });
            listaVeiculo.Add(new Veiculo() { Empresa = 1, Filial = 1, Garagem = 1, Placa = "DDD-0000", Prefixo = "0000004", Condicao = eCondicao.Sucateado, MyEnum = MyEnum.b2 });
            listaVeiculo.Add(new Veiculo() { Empresa = 1, Filial = 1, Garagem = 1, Placa = "EEE-0000", Prefixo = "0000005", Condicao = eCondicao.Vendido, MyEnum = MyEnum.c1 });
            listaVeiculo.Add(new Veiculo() { Empresa = 1, Filial = 1, Garagem = 1, Placa = "FFF-0000", Prefixo = "0000006", Condicao = eCondicao.Ativo, MyEnum = MyEnum.c2 });
            listaVeiculo.Add(new Veiculo() { Empresa = 1, Filial = 1, Garagem = 1, Placa = "GGG-0000", Prefixo = "0000007", Condicao = eCondicao.Ativo, MyEnum = MyEnum.d1 });
            listaVeiculo.Add(new Veiculo() { Empresa = 1, Filial = 1, Garagem = 1, Placa = "HHH-0000", Prefixo = "0000008", Condicao = eCondicao.Reformado, MyEnum = MyEnum.d2 });
            listaVeiculo.Add(new Veiculo() { Empresa = 1, Filial = 1, Garagem = 1, Placa = "III-0000", Prefixo = "0000009", Condicao = eCondicao.Sucateado, MyEnum = MyEnum.a1 });
            listaVeiculo.Add(new Veiculo() { Empresa = 1, Filial = 1, Garagem = 1, Placa = "JJJ-0000", Prefixo = "0000010", Condicao = eCondicao.Ativo, MyEnum = MyEnum.a1 });
            listaVeiculo.Add(new Veiculo() { Empresa = 1, Filial = 1, Garagem = 1, Placa = "LLL-0000", Prefixo = "0000011", Condicao = eCondicao.Vendido, MyEnum = MyEnum.b2 });
            listaVeiculo.Add(new Veiculo() { Empresa = 1, Filial = 1, Garagem = 1, Placa = "MMM-0000", Prefixo = "0000012", Condicao = eCondicao.Vendido, MyEnum = MyEnum.b2 });

            cmbBxEdtTipo.AdicionarItens<eCondicao>(eCondicao.Ativo);

        }

        private FGlobus.Componentes.WinForms.AssociacaoBGM.CondicaoAssociacaoBGM associacaoBGM1_CondicaoItemAssociado(
            object sender)
        {
            return new FGlobus.Componentes.WinForms.AssociacaoBGM.CondicaoAssociacaoBGM()
                .Adicionar("Condicao", cmbBxEdtTipo.RetornarItem<eCondicao>());
        }

    }

    public class Veiculo
    {
        public int Empresa { get; set; }
        public int Filial { get; set; }
        public int Garagem { get; set; }
        public string Placa { get; set; }
        public string Prefixo { get; set; }
        public eCondicao Condicao { get; set; }
        public MyEnum MyEnum { get; set; }
    }

    public enum MyEnum
    {
        [XmlEnum("a = 1")]
        a1,
        [XmlEnum("b = 1")]
        b1,
        [XmlEnum("c = 1")]
        c1,
        [XmlEnum("d = 1")]
        d1,
        [XmlEnum("a = 2")]
        a2,
        [XmlEnum("b = 2")]
        b2,
        [XmlEnum("c = 2")]
        c2,
        [XmlEnum("d = 2")]
        d2,

    }

    public enum eCondicao
    {
        Ativo,
        Inativo,
        Sucateado,
        Vendido,
        Reformado,
        Nenhum
    }


}


//10 - 41524 Refatorar a propriedade "TipoDeMascara" do controle "ButtonEditBGM"
//09 - 38892 Criar componente de pesquisa aleat¢ria para N£meros, Strings, Datas e ect.
//08 - 47634 Criar recurso para grava‡Æo de log nos grids

//07 - 48794 Reestruturar setup e botäes de impressÆo do Globus+. 
//06 - 46024 Desenvolver rotina de impressÆo matricial 

//05 - 45911 Mensagens e notifica‡äes estÆo deixando o menu principal lento.

//04 - 46777 Incluir rotina para salvar e restaurar os parƒmetros do controle CustomGridBGM, o layout do GridControl associado e o layout do PivotGrid Complemento do SIM 44501
//03 - 44501 Criar componente para customizar o componente GridControl 
//02 - 46776 Incluir formata‡Æo condicional no componente CustomGridBGM

//01 - 45204 Desenvolver componente GridControlBGM;
//00 - 46207 Desenvolver componente TabControlBGM


//Peso - N°SIM
// 10  - 41524 
// 09  - 38892 
// 08  - 47634 
// 07  - 48794 
// 06  - 46024 
// 05  - 45911 
// 04  - 46777 
// 03  - 44501 
// 02  - 46776      
// 01  - 45204 
// 00  - 46207 