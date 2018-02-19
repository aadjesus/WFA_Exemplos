using System.Collections.Generic;
using System.Dynamic;

namespace WFA_Workflow.AutorizaGridsBGMx
{
    class Class3
    {
        //private ICollection _disponiveis;
        //private ICollection _associados;

        //public virtual void PopularDisponiveis<T>(IEnumerable<T> disponiveis)
        //{
        //    _disponiveis = disponiveis.ToArray();
        //}

        //public virtual void PopularGrids<T1, T2>(IEnumerable<T1> disponiveis, IEnumerable<T2> associados)
        //{
        //    //_disponiveis = disponiveis.ToArray();
        //    _associados = associados.ToArray();
        //    //_associados.GetType().GetProperty

        //    PropertyInfo[] instanceProps = _associados.GetType().GetProperties();

        //    var values = new Dictionary<string, object>();
        //    values.Add("Title", "Hello World!");
        //    values.Add("Text", "My first post");
        //    values.Add("Tags", new[] { "hello", "world" });

        //    var post = new DynamicEntity(values);

        //    dynamic dynPost = post;
        //    string text = dynPost.Text;
        //    object text1 = dynPost.Tags;
        //    if (text == null || text1 == null)
        //    {

        //    }


        //    //PropertyDescriptorCollection propsCollection = new PropertyDescriptorCollection(instanceProps.Cast<PropertyDescriptor>().ToArray());
        //    //if (propsCollection == null)
        //    //{                
        //    //}

        //    //TypeDescriptor.CreateProperty(this.GetType(), "", bool, attrs);

        //    //disponiveis
        //    //    .ToList()
        //    //    .ForEach(f => 
        //    //    {
        //    //        _colunas.Where(w=> w.Chave)
        //    //        //f.GetType()
        //    //        //_disponiveis
        //    //    });

        //    //IEnumerable<T1> disponiveis = disponiveis
        //    //    .ToList() 
        //    //    .RemoveAll( )

        //    //_disponiveis = ;
        //    //_associados = disponiveis.ToArray();

        //    //_disponiveis.
        //}


        //ICollection
        //public abstract class Items<T> 
        //{ 

        //}



        //public Func<T, bool> ANDOnlyParams<T>(string[] paramNames, object[] values)
        //{
        //    List<ParameterExpression> paramList = new List<ParameterExpression>();
        //    foreach (string param in paramNames)
        //        paramList.Add(Expression.Parameter(typeof(T), param));

        //    List<LambdaExpression> lexList = new List<LambdaExpression>();
        //    for (int i = 0; i < paramNames.Length; i++)
        //    {
        //        Expression bodyInner = null;
        //        if (i == 0)
        //        {
        //            bodyInner = Expression.Equal(
        //                                Expression.Property(
        //                                    paramList[i], paramNames[i]),
        //                                    Expression.Constant(values[i]));

        //        }
        //        else
        //        {
        //            bodyInner = Expression.And(
        //                                Expression.Equal(
        //                                Expression.Property(
        //                                paramList[i], paramNames[i]),
        //                                Expression.Constant(values[i])),
        //                                Expression.Invoke(lexList[i - 1], paramList[i]));

        //        }
        //        lexList.Add(Expression.Lambda(bodyInner, paramList[i]));
        //    }

        //    return ((Expression<Func<T, bool>>)lexList[lexList.Count - 1]).Compile();
        //}

        //public virtual void PopularGrids<T1, T2>(IEnumerable<T1> disponiveis, IEnumerable<T2> associados)
        //{
        //    if (disponiveis != null && disponiveis.Count() > 0)
        //    {
        //        List<T1> listaDisponiveis = disponiveis.ToList();

        //        if (_gridControlDisponiveis == null)
        //            CriarGridControl();
        //        _gridControlDisponiveis.DataSource = listaDisponiveis.ToArray();

        //        if (_gridControlAssociados != null)
        //        {
        //            _gridControlAssociados.DataSource = disponiveis
        //                .Aggregate(new List<T1>(), (a1, b1) =>
        //                {
        //                    //ParameterExpression parameterExpressionT1 = Expression.Parameter(typeof(T1), "p");
        //                    //ParameterExpression parameterExpressionT2 = Expression.Parameter(typeof(T2), "p");

        //                    //int i = 0;
        //                    //List<LambdaExpression> listaLambdaExpression = _colunas
        //                    //    .Where(w => w.Chave)
        //                    //    .Aggregate(new List<LambdaExpression>(), (a, b) =>
        //                    //    {
        //                    //        var valor = b1.GetType().GetProperty(b.Campo).GetValue(b1, null);
        //                    //        Expression expression;

        //                    //        if (i.Equals(0))
        //                    //            expression = Expression.Equal(
        //                    //                                Expression.Property(
        //                    //                                    parameterExpressionT2, b.Campo),
        //                    //                                    Expression.Constant(valor));
        //                    //        else
        //                    //            expression = Expression.And(
        //                    //                                Expression.Equal(
        //                    //                                Expression.Property(
        //                    //                                parameterExpressionT2, b.Campo),
        //                    //                                Expression.Constant(valor)),
        //                    //                                Expression.Invoke(a[i - 1], parameterExpressionT2));

        //                    //        a.Add(Expression.Lambda(expression, parameterExpressionT2));
        //                    //        i++;
        //                    //        return a;
        //                    //    });

        //                    //var xx = ((Expression<Func<T1, bool>>)listaLambdaExpression[listaLambdaExpression.Count - 1]).Compile();

        //                    //if (disponiveis
        //                    //    .Where(w => xx(w)  ).Count() > 0)
        //                    //{

        //                    //}

        //                    Func<T1, bool> aaa = delegate(T1 item)
        //                    {
        //                        var xx = _colunas
        //                            .Where(w => w.Chave)
        //                            .Join(item.GetType().GetProperties(),
        //                                    a => a.Campo,
        //                                    b => b.Name,
        //                                    (a, b) => b.GetValue(item, null))
        //                            .Aggregate("", (a, b) => String.Concat(a, ";", b));

        //                        var xx2 = associados
        //                            .Aggregate(new List<string>(), (a, b) =>
        //                            {

        //                                return a;
        //                            });




        //                        if (xx == null)
        //                        {

        //                        }

        //                        return true;
        //                    };

        //                    if (disponiveis
        //                        .Where(w => aaa(w)).Count() > 0)
        //                    {

        //                    }

        //                    a1.Add(b1);
        //                    return a1;
        //                })
        //                .ToArray();

        //        }
        //    }
        //}

        //public virtual void PopularGridDisponivei<T>(IEnumerable<T> disponiveis)
        //{
        //    if (_gridControlDisponiveis == null)
        //        CriarGridControl();
        //    _gridControlDisponiveis.DataSource = disponiveis.ToArray();
        //}

        //public virtual IEnumerable<T> RetornarAssociados<T>()
        //{
        //    return null;
        //}
    }


    public class DynamicEntity : DynamicObject
    {
        private IDictionary<string, object> _values;

        public DynamicEntity(IDictionary<string, object> values)
        {
            _values = values;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (_values.ContainsKey(binder.Name))
            {
                result = _values[binder.Name];
                return true;
            }
            result = null;
            return false;
        }
    }

}
