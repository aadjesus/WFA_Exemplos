using System.Windows.Forms;

namespace WFA_Workflow
{
    public partial class FrmNHibernate : Form
    {
        public FrmNHibernate()
        {
            InitializeComponent();
        }
    }

    //public static class ExtensionMethods_NHibernate
    //{

    //    // Dado um tipo de entidade, retorna todas as propriedades que são mapeadas como componentes; TODAS como PROPRIEDADES mapeadas parágrafo UMA determinada Entidade;
    //    public static IEnumerable<PropertyInfo> GetComponents(this ISessionFactory sessionFactory, Type entityType)
    //    {
    //        String entityName = (sessionFactory as ISessionFactoryImplementor).TryGetGuessEntityName(entityType);
    //        IClassMetadata metadata = sessionFactory.GetClassMetadata(entityName);
    //        for (Int32 i = 0; i < metadata.PropertyTypes.Length; ++i)
    //        {
    //            IType property = metadata.PropertyTypes[i];
    //            if (property is ComponentType)
    //            {
    //                String propertyName = metadata.PropertyNames[i];
    //                yield return (entityType.GetProperty(propertyName));
    //            }
    //        }
    //    }

    //    // Todas as propriedades que são mapeadas como tipos de usuário personalizadas;
    //    public static IEnumerable<PropertyInfo> GetUserTypes(this ISessionFactory sessionFactory, Type entityType)
    //    {
    //        String entityName = (sessionFactory as ISessionFactoryImplementor).TryGetGuessEntityName(entityType);
    //        IClassMetadata metadata = sessionFactory.GetClassMetadata(entityName);
    //        for (Int32 i = 0; i < metadata.PropertyTypes.Length; ++i)
    //        {
    //            IType property = metadata.PropertyTypes[i];
    //            if (property is CustomType)
    //            {
    //                String propertyName = metadata.PropertyNames[i];
    //                yield return (entityType.GetProperty(propertyName));
    //            }
    //        }
    //    }

    //    // Todas as propriedades mapeadas para uma determinada entidade;
    //    public static IEnumerable<PropertyInfo> GetProperties(this ISessionFactory sessionFactory, Type entityType)
    //    {
    //        String entityName = (sessionFactory as ISessionFactoryImplementor).TryGetGuessEntityName(entityType);
    //        IClassMetadata metadata = sessionFactory.GetClassMetadata(entityName);

    //        for (Int32 i = 0; i < metadata.PropertyTypes.Length; ++i)
    //        {
    //            IType property = metadata.PropertyTypes[i];

    //            if (!(property is OneToOneType) && !(property is ManyToOneType) && !(property is ComponentType))
    //            {
    //                String propertyName = metadata.PropertyNames[i];
    //                yield return (entityType.GetProperty(propertyName));
    //            }
    //        }
    //    }

    //    // Propriedades mapeadas como um para um ou muitos para um, ou seja, que apontam para uma outra entidade;
    //    public static IEnumerable<PropertyInfo> GetAssociations(this ISessionFactory sessionFactory, Type entityType)
    //    {
    //        String entityName = (sessionFactory as ISessionFactoryImplementor).TryGetGuessEntityName(entityType);
    //        IClassMetadata metadata = sessionFactory.GetClassMetadata(entityName);

    //        for (Int32 i = 0; i < metadata.PropertyTypes.Length; ++i)
    //        {
    //            IType property = metadata.PropertyTypes[i];

    //            if (property is OneToOneType)
    //            {
    //                String propertyName = metadata.PropertyNames[i];
    //                yield return (entityType.GetProperty(propertyName));
    //            }
    //            else if (property is ManyToOneType)
    //            {
    //                String propertyName = metadata.PropertyNames[i];
    //                yield return (entityType.GetProperty(propertyName));
    //            }
    //        }
    //    }

    //    // A propriedade que é mapeado como o identificador;
    //    public static PropertyInfo GetIdentifier(this ISessionFactory sessionFactory, Type entityType)
    //    {
    //        String entityName = (sessionFactory as ISessionFactoryImplementor).TryGetGuessEntityName(entityType);
    //        AbstractEntityPersister persister = (sessionFactory as ISessionFactoryImplementor).TryGetEntityPersister(entityName) as AbstractEntityPersister;

    //        if (persister != null)
    //            return (entityType.GetProperty(persister.IdentifierPropertyName));
    //        else
    //            return null;
    //    }

    //    // Os nomes da coluna (s) que compõem a chave primária da tabela;
    //    public static IEnumerable<String> GetIdentifierColumnNames(this ISessionFactory sessionFactory, Type entityType)
    //    {
    //        String entityName = (sessionFactory as ISessionFactoryImplementor).TryGetGuessEntityName(entityType);
    //        AbstractEntityPersister persister = (sessionFactory as ISessionFactoryImplementor).TryGetEntityPersister(entityName) as AbstractEntityPersister;

    //        if (persister != null)
    //            return (persister.IdentifierColumnNames);
    //        else
    //            return null;
    //    }

    //    // Coluna da tabela ou exibição que armazenar uma determinada propriedade.
    //    public static String GetColumnName(this ISessionFactory sessionFactory, Type entityType, String propertyName)
    //    {
    //        String entityName = (sessionFactory as ISessionFactoryImplementor).TryGetGuessEntityName(entityType);
    //        AbstractEntityPersister persister = (sessionFactory as ISessionFactoryImplementor).TryGetEntityPersister(entityName) as AbstractEntityPersister;

    //        if (persister != null)
    //            return (persister.GetPropertyColumnNames(propertyName).SingleOrDefault());
    //        else
    //            return null;
    //    }

    //    // O nome da tabela ou vista que a entidade é armazenada;
    //    public static String GetTableName(this ISessionFactory sessionFactory, Type entityType)
    //    {
    //        String entityName = (sessionFactory as ISessionFactoryImplementor).TryGetGuessEntityName(entityType);
    //        AbstractEntityPersister persister = (sessionFactory as ISessionFactoryImplementor).TryGetEntityPersister(entityName) as AbstractEntityPersister;

    //        if (persister != null)
    //            return (persister.TableName);
    //        else
    //            return null;
    //    }

    //    // Propriedades mapeadas como de um para muitos, isto é, coleções, de qualquer tipo;
    //    public static IEnumerable<PropertyInfo> GetCollections(this ISessionFactory sessionFactory, Type entityType)
    //    {
    //        String entityName = (sessionFactory as ISessionFactoryImplementor).TryGetGuessEntityName(entityType);
    //        IClassMetadata metadata = sessionFactory.GetClassMetadata(entityName);
    //        String prefix = String.Concat(entityName, ".");
    //        IDictionary<String, ICollectionMetadata> collectionMetadata = sessionFactory.GetAllCollectionMetadata().Where(x => x.Key.StartsWith(prefix)).ToDictionary(x => x.Key, x => x.Value);

    //        foreach (String key in collectionMetadata.Keys)
    //        {
    //            String propertyName = key.Replace(prefix, String.Empty);
    //            yield return (entityType.GetProperty(propertyName));
    //        }
    //    }
    //}
}


