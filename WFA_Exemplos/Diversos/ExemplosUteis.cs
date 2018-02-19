using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Reflection;

namespace WFA_Workflow
{
    public static class ExemplosUteis
    {
        // ####################################################
        #region // #################### T E S T E S ###################

        public static void xxx()
        {
            List<sBet_XX_ween> listasBetween = new List<sBet_XX_ween>() 
            {
                new sBet_XX_ween(){ Int_ = 1, DateTime_ = new DateTime(2012,1,1), String_="a"} ,
		        new sBet_XX_ween(){ Int_ = 2, DateTime_ = new DateTime(2012,1,2), String_="b"} ,
		        new sBet_XX_ween(){ Int_ = 3, DateTime_ = new DateTime(2012,1,3), String_="c"} ,
		        new sBet_XX_ween(){ Int_ = 4, DateTime_ = new DateTime(2012,1,3)} ,
		        new sBet_XX_ween(){ Int_ = 5, DateTime_ = new DateTime(2012,1,4), String_="e"} ,
		        new sBet_XX_ween(){ Int_ = 6, DateTime_ = new DateTime(2012,1,5), String_="f"} ,
		        new sBet_XX_ween(){ Int_ = 7, DateTime_ = new DateTime(2012,1,6), String_="g"} ,
	        };

            

            if (listasBetween.Count() > 0)
                listasBetween

                        .Between(b => b.Int_, 2, 5)
                        .Between(b => b.DateTime_, new DateTime(2012, 1, 3), new DateTime(2012, 1, 4))
                        .Between(b => b.String_, "c", "d")

                    .Aggregate((a, b) =>
                    {
                        Console.WriteLine(String.Concat(b.GetType().GetProperties().Select(s => String.Concat(s.GetValue(b, null), " ")).ToArray()));
                        return a;
                    });
        }

        public struct sBet_XX_ween
        {
            public int? Int_ { get; set; }
            public string String_ { get; set; }
            public DateTime? DateTime_ { get; set; }
            public bool Bool_ { get; set; }

        }

        #endregion
        // ####################################################

        /// <summary>
        /// Executa o filtro na lista conforme o valor inicial e valor final
        /// <list type="number">
        /// </list>
        /// </summary>
        /// <typeparam name="TSource">Lista</typeparam>
        /// <typeparam name="TKey">Propriedade</typeparam>
        /// <param name="source">Lista</param>
        /// <param name="keySelector">Propriedade</param>
        /// <param name="valorInicial">Valor inicial</param>
        /// <param name="valorFinal">Valor final</param>
        /// <example>Exemplo:  
        ///     <code>
        ///         Lista.Between(p => p.NomeDaProrpiedade, 1, 10);
        ///     </code>
        /// </example>
        /// <exception cref="A propriedade informado não é derivada de 'MemberExpression'"/>
        /// <exception cref="O tipo da propriedade informado não é derivada de 'IComparable'."/>
        /// <exception cref="O valor inicial e final não pode ser nulo."/>
        /// <exception cref="O valor inicial não pode ser maior que o valor final.."/>
        /// <returns>Objeto do tipo informado</returns>
        public static IEnumerable<TSource> Between<TSource, TKey>(
             this IEnumerable<TSource> source,
             Expression<Func<TSource, TKey>> keySelector,
             TKey valorInicial,
             TKey valorFinal) //where TKey : IComparable<TKey>
        {
            MemberExpression memberExpression = keySelector.Body as MemberExpression;
            if (memberExpression == null)
                throw new Exception("# Erro # A propriedade informado não é derivada de 'MemberExpression'.");

            if (memberExpression.Type.BaseType != typeof(System.ValueType) &&
                memberExpression.Type != typeof(System.String))
                throw new Exception("# Erro # O tipo da propriedade informado não é derivada de 'IComparable'.");

            if (valorInicial == null || valorFinal == null)
                throw new Exception("# Erro # O valor inicial ou o valor final não pode ser nulo.");

            if (valorInicial.ToString().CompareTo(valorFinal.ToString()).Equals(1))
                throw new Exception("# Erro # O valor inicial não pode ser maior que o valor final.");

            MemberInfo memberInfo = source.FirstOrDefault().GetType().GetMember(memberExpression.Member.Name).FirstOrDefault();

            Func<TSource, bool> delegateFiltroString = delegate(TSource objeto)
            {
                object valor = null;
                if (memberInfo.MemberType.Equals(MemberTypes.Field))
                    valor = (memberInfo as FieldInfo).GetValue(objeto);
                else
                    valor = (memberInfo as PropertyInfo).GetValue(objeto, null);

                return valor != null &&
                       valor.ToString().CompareTo(valorInicial.ToString()) >= 0 &&
                       valor.ToString().CompareTo(valorFinal.ToString()) <= 0;
            };

            return source
                .Where(delegateFiltroString);
        }

    }
}