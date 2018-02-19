namespace WFA_Workflow
{
    partial class FrmNHibernate
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "public static class ExtensionMethods_NHibernate",
            "{",
            "",
            "    // Dado um tipo de entidade, retorna todas as propriedades que são mapeadas c" +
                "omo componentes; TODAS como PROPRIEDADES mapeadas parágrafo UMA determinada Enti" +
                "dade;",
            "    public static IEnumerable<PropertyInfo> GetComponents(this ISessionFactory se" +
                "ssionFactory, Type entityType)",
            "        {",
            "            String entityName = (sessionFactory as ISessionFactoryImplementor).Tr" +
                "yGetGuessEntityName(entityType);",
            "            IClassMetadata metadata = sessionFactory.GetClassMetadata(entityName)" +
                ";",
            "            for (Int32 i = 0; i < metadata.PropertyTypes.Length; ++i)",
            "            {",
            "                IType property = metadata.PropertyTypes[i];",
            "                if (property is ComponentType)",
            "                {",
            "                    String propertyName = metadata.PropertyNames[i];",
            "                    yield return (entityType.GetProperty(propertyName));",
            "                }",
            "            }",
            "        }",
            "",
            "    // Todas as propriedades que são mapeadas como tipos de usuário personalizada" +
                "s;",
            "    public static IEnumerable<PropertyInfo> GetUserTypes(this ISessionFactory ses" +
                "sionFactory, Type entityType)",
            "        {",
            "            String entityName = (sessionFactory as ISessionFactoryImplementor).Tr" +
                "yGetGuessEntityName(entityType);",
            "            IClassMetadata metadata = sessionFactory.GetClassMetadata(entityName)" +
                ";",
            "            for (Int32 i = 0; i < metadata.PropertyTypes.Length; ++i)",
            "            {",
            "                IType property = metadata.PropertyTypes[i];",
            "                if (property is CustomType)",
            "                {",
            "                    String propertyName = metadata.PropertyNames[i];",
            "                    yield return (entityType.GetProperty(propertyName));",
            "                }",
            "            }",
            "        }",
            "",
            "    // Todas as propriedades mapeadas para uma determinada entidade;",
            "    public static IEnumerable<PropertyInfo> GetProperties(this ISessionFactory se" +
                "ssionFactory, Type entityType)",
            "        {",
            "            String entityName = (sessionFactory as ISessionFactoryImplementor).Tr" +
                "yGetGuessEntityName(entityType);",
            "            IClassMetadata metadata = sessionFactory.GetClassMetadata(entityName)" +
                ";",
            "",
            "            for (Int32 i = 0; i < metadata.PropertyTypes.Length; ++i)",
            "            {",
            "                IType property = metadata.PropertyTypes[i];",
            "",
            "                if (!(property is OneToOneType) && !(property is ManyToOneType) &" +
                "& !(property is ComponentType))",
            "                {",
            "                    String propertyName = metadata.PropertyNames[i];",
            "                    yield return (entityType.GetProperty(propertyName));",
            "                }",
            "            }",
            "        }",
            "",
            "    // Propriedades mapeadas como um para um ou muitos para um, ou seja, que apon" +
                "tam para uma outra entidade;",
            "    public static IEnumerable<PropertyInfo> GetAssociations(this ISessionFactory " +
                "sessionFactory, Type entityType)",
            "        {",
            "            String entityName = (sessionFactory as ISessionFactoryImplementor).Tr" +
                "yGetGuessEntityName(entityType);",
            "            IClassMetadata metadata = sessionFactory.GetClassMetadata(entityName)" +
                ";",
            "",
            "            for (Int32 i = 0; i < metadata.PropertyTypes.Length; ++i)",
            "            {",
            "                IType property = metadata.PropertyTypes[i];",
            "",
            "                if (property is OneToOneType)",
            "                {",
            "                    String propertyName = metadata.PropertyNames[i];",
            "                    yield return (entityType.GetProperty(propertyName));",
            "                }",
            "                else if (property is ManyToOneType)",
            "                {",
            "                    String propertyName = metadata.PropertyNames[i];",
            "                    yield return (entityType.GetProperty(propertyName));",
            "                }",
            "            }",
            "        }",
            "",
            "    // A propriedade que é mapeado como o identificador;",
            "    public static PropertyInfo GetIdentifier(this ISessionFactory sessionFactory," +
                " Type entityType)",
            "        {",
            "            String entityName = (sessionFactory as ISessionFactoryImplementor).Tr" +
                "yGetGuessEntityName(entityType);",
            "            AbstractEntityPersister persister = (sessionFactory as ISessionFactor" +
                "yImplementor).TryGetEntityPersister(entityName) as AbstractEntityPersister;",
            "",
            "            if (persister != null)",
            "                return (entityType.GetProperty(persister.IdentifierPropertyName))" +
                ";",
            "            else",
            "                return null;",
            "        }",
            "",
            "    // Os nomes da coluna (s) que compõem a chave primária da tabela;",
            "    public static IEnumerable<String> GetIdentifierColumnNames(this ISessionFacto" +
                "ry sessionFactory, Type entityType)",
            "        {",
            "            String entityName = (sessionFactory as ISessionFactoryImplementor).Tr" +
                "yGetGuessEntityName(entityType);",
            "            AbstractEntityPersister persister = (sessionFactory as ISessionFactor" +
                "yImplementor).TryGetEntityPersister(entityName) as AbstractEntityPersister;",
            "",
            "            if (persister != null)",
            "                return (persister.IdentifierColumnNames);",
            "            else",
            "                return null;",
            "        }",
            "",
            "    // Coluna da tabela ou exibição que armazenar uma determinada propriedade.",
            "    public static String GetColumnName(this ISessionFactory sessionFactory, Type " +
                "entityType, String propertyName)",
            "        {",
            "            String entityName = (sessionFactory as ISessionFactoryImplementor).Tr" +
                "yGetGuessEntityName(entityType);",
            "            AbstractEntityPersister persister = (sessionFactory as ISessionFactor" +
                "yImplementor).TryGetEntityPersister(entityName) as AbstractEntityPersister;",
            "",
            "            if (persister != null)",
            "                return (persister.GetPropertyColumnNames(propertyName).SingleOrDe" +
                "fault());",
            "            else",
            "                return null;",
            "        }",
            "",
            "    // O nome da tabela ou vista que a entidade é armazenada;",
            "    public static String GetTableName(this ISessionFactory sessionFactory, Type e" +
                "ntityType)",
            "        {",
            "            String entityName = (sessionFactory as ISessionFactoryImplementor).Tr" +
                "yGetGuessEntityName(entityType);",
            "            AbstractEntityPersister persister = (sessionFactory as ISessionFactor" +
                "yImplementor).TryGetEntityPersister(entityName) as AbstractEntityPersister;",
            "",
            "            if (persister != null)",
            "                return (persister.TableName);",
            "            else",
            "                return null;",
            "        }",
            "",
            "    // Propriedades mapeadas como de um para muitos, isto é, coleções, de qualque" +
                "r tipo;",
            "    public static IEnumerable<PropertyInfo> GetCollections(this ISessionFactory s" +
                "essionFactory, Type entityType)",
            "        {",
            "            String entityName = (sessionFactory as ISessionFactoryImplementor).Tr" +
                "yGetGuessEntityName(entityType);",
            "            IClassMetadata metadata = sessionFactory.GetClassMetadata(entityName)" +
                ";",
            "            String prefix = String.Concat(entityName, \".\");",
            "            IDictionary<String, ICollectionMetadata> collectionMetadata = session" +
                "Factory.GetAllCollectionMetadata().Where(x => x.Key.StartsWith(prefix)).ToDictio" +
                "nary(x => x.Key, x => x.Value);",
            "",
            "            foreach (String key in collectionMetadata.Keys)",
            "            {",
            "                String propertyName = key.Replace(prefix, String.Empty);",
            "                yield return (entityType.GetProperty(propertyName));",
            "            }",
            "        }",
            "}"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(938, 670);
            this.listBox1.TabIndex = 0;
            // 
            // FrmNHibernate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 670);
            this.Controls.Add(this.listBox1);
            this.Name = "FrmNHibernate";
            this.Text = "FrmNHibernate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}