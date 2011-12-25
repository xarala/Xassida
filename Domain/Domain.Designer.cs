﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Domain", "XasidaBeyit", "Xasida", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Model.Xasida), "Beyit", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Model.Beyit), true)]
[assembly: EdmRelationshipAttribute("Domain", "BeyitBahru", "Beyit", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Model.Beyit), "Bahru", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Model.Bahru), true)]
[assembly: EdmRelationshipAttribute("Domain", "XasidaMole", "Xasida", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Model.Xasida), "Mole", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Model.Mole))]

#endregion

namespace Model
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DomainContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DomainContainer object using the connection string found in the 'DomainContainer' section of the application configuration file.
        /// </summary>
        public DomainContainer() : base("name=DomainContainer", "DomainContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DomainContainer object.
        /// </summary>
        public DomainContainer(string connectionString) : base(connectionString, "DomainContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DomainContainer object.
        /// </summary>
        public DomainContainer(EntityConnection connection) : base(connection, "DomainContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Xasida> XasidaSet
        {
            get
            {
                if ((_XasidaSet == null))
                {
                    _XasidaSet = base.CreateObjectSet<Xasida>("XasidaSet");
                }
                return _XasidaSet;
            }
        }
        private ObjectSet<Xasida> _XasidaSet;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Beyit> BeyitSet
        {
            get
            {
                if ((_BeyitSet == null))
                {
                    _BeyitSet = base.CreateObjectSet<Beyit>("BeyitSet");
                }
                return _BeyitSet;
            }
        }
        private ObjectSet<Beyit> _BeyitSet;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Bahru> BahruSet
        {
            get
            {
                if ((_BahruSet == null))
                {
                    _BahruSet = base.CreateObjectSet<Bahru>("BahruSet");
                }
                return _BahruSet;
            }
        }
        private ObjectSet<Bahru> _BahruSet;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Mole> MoleSet
        {
            get
            {
                if ((_MoleSet == null))
                {
                    _MoleSet = base.CreateObjectSet<Mole>("MoleSet");
                }
                return _MoleSet;
            }
        }
        private ObjectSet<Mole> _MoleSet;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the XasidaSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToXasidaSet(Xasida xasida)
        {
            base.AddObject("XasidaSet", xasida);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the BeyitSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBeyitSet(Beyit beyit)
        {
            base.AddObject("BeyitSet", beyit);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the BahruSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBahruSet(Bahru bahru)
        {
            base.AddObject("BahruSet", bahru);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the MoleSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMoleSet(Mole mole)
        {
            base.AddObject("MoleSet", mole);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Domain", Name="Bahru")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Bahru : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Bahru object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="beyitId">Initial value of the BeyitId property.</param>
        /// <param name="position">Initial value of the Position property.</param>
        /// <param name="contenu">Initial value of the Contenu property.</param>
        /// <param name="beyitId1">Initial value of the BeyitId1 property.</param>
        public static Bahru CreateBahru(global::System.Int32 id, global::System.Int32 beyitId, global::System.Int16 position, global::System.String contenu, global::System.Int32 beyitId1)
        {
            Bahru bahru = new Bahru();
            bahru.Id = id;
            bahru.BeyitId = beyitId;
            bahru.Position = position;
            bahru.Contenu = contenu;
            bahru.BeyitId1 = beyitId1;
            return bahru;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BeyitId
        {
            get
            {
                return _BeyitId;
            }
            set
            {
                OnBeyitIdChanging(value);
                ReportPropertyChanging("BeyitId");
                _BeyitId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BeyitId");
                OnBeyitIdChanged();
            }
        }
        private global::System.Int32 _BeyitId;
        partial void OnBeyitIdChanging(global::System.Int32 value);
        partial void OnBeyitIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 Position
        {
            get
            {
                return _Position;
            }
            set
            {
                OnPositionChanging(value);
                ReportPropertyChanging("Position");
                _Position = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Position");
                OnPositionChanged();
            }
        }
        private global::System.Int16 _Position;
        partial void OnPositionChanging(global::System.Int16 value);
        partial void OnPositionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Contenu
        {
            get
            {
                return _Contenu;
            }
            set
            {
                OnContenuChanging(value);
                ReportPropertyChanging("Contenu");
                _Contenu = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Contenu");
                OnContenuChanged();
            }
        }
        private global::System.String _Contenu;
        partial void OnContenuChanging(global::System.String value);
        partial void OnContenuChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BeyitId1
        {
            get
            {
                return _BeyitId1;
            }
            set
            {
                OnBeyitId1Changing(value);
                ReportPropertyChanging("BeyitId1");
                _BeyitId1 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BeyitId1");
                OnBeyitId1Changed();
            }
        }
        private global::System.Int32 _BeyitId1;
        partial void OnBeyitId1Changing(global::System.Int32 value);
        partial void OnBeyitId1Changed();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Domain", "BeyitBahru", "Beyit")]
        public Beyit Beyit
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Beyit>("Domain.BeyitBahru", "Beyit").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Beyit>("Domain.BeyitBahru", "Beyit").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Beyit> BeyitReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Beyit>("Domain.BeyitBahru", "Beyit");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Beyit>("Domain.BeyitBahru", "Beyit", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Domain", Name="Beyit")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Beyit : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Beyit object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="xasidaId">Initial value of the XasidaId property.</param>
        /// <param name="position">Initial value of the Position property.</param>
        /// <param name="xasidaTitre">Initial value of the XasidaTitre property.</param>
        public static Beyit CreateBeyit(global::System.Int32 id, global::System.String xasidaId, global::System.String position, global::System.Int32 xasidaTitre)
        {
            Beyit beyit = new Beyit();
            beyit.Id = id;
            beyit.XasidaId = xasidaId;
            beyit.Position = position;
            beyit.XasidaTitre = xasidaTitre;
            return beyit;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String XasidaId
        {
            get
            {
                return _XasidaId;
            }
            set
            {
                OnXasidaIdChanging(value);
                ReportPropertyChanging("XasidaId");
                _XasidaId = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("XasidaId");
                OnXasidaIdChanged();
            }
        }
        private global::System.String _XasidaId;
        partial void OnXasidaIdChanging(global::System.String value);
        partial void OnXasidaIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Position
        {
            get
            {
                return _Position;
            }
            set
            {
                OnPositionChanging(value);
                ReportPropertyChanging("Position");
                _Position = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Position");
                OnPositionChanged();
            }
        }
        private global::System.String _Position;
        partial void OnPositionChanging(global::System.String value);
        partial void OnPositionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 XasidaTitre
        {
            get
            {
                return _XasidaTitre;
            }
            set
            {
                OnXasidaTitreChanging(value);
                ReportPropertyChanging("XasidaTitre");
                _XasidaTitre = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("XasidaTitre");
                OnXasidaTitreChanged();
            }
        }
        private global::System.Int32 _XasidaTitre;
        partial void OnXasidaTitreChanging(global::System.Int32 value);
        partial void OnXasidaTitreChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Domain", "XasidaBeyit", "Xasida")]
        public Xasida Xasida
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Xasida>("Domain.XasidaBeyit", "Xasida").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Xasida>("Domain.XasidaBeyit", "Xasida").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Xasida> XasidaReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Xasida>("Domain.XasidaBeyit", "Xasida");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Xasida>("Domain.XasidaBeyit", "Xasida", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Domain", "BeyitBahru", "Bahru")]
        public EntityCollection<Bahru> Bahru
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Bahru>("Domain.BeyitBahru", "Bahru");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Bahru>("Domain.BeyitBahru", "Bahru", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Domain", Name="Mole")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Mole : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Mole object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="titre">Initial value of the Titre property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        public static Mole CreateMole(global::System.Int32 id, global::System.String titre, global::System.String description)
        {
            Mole mole = new Mole();
            mole.Id = id;
            mole.Titre = titre;
            mole.Description = description;
            return mole;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Titre
        {
            get
            {
                return _Titre;
            }
            set
            {
                OnTitreChanging(value);
                ReportPropertyChanging("Titre");
                _Titre = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Titre");
                OnTitreChanged();
            }
        }
        private global::System.String _Titre;
        partial void OnTitreChanging(global::System.String value);
        partial void OnTitreChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Domain", "XasidaMole", "Xasida")]
        public EntityCollection<Xasida> Xasidas
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Xasida>("Domain.XasidaMole", "Xasida");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Xasida>("Domain.XasidaMole", "Xasida", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Domain", Name="Xasida")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Xasida : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Xasida object.
        /// </summary>
        /// <param name="titre">Initial value of the Titre property.</param>
        /// <param name="tardioumane">Initial value of the Tardioumane property.</param>
        /// <param name="langue">Initial value of the Langue property.</param>
        public static Xasida CreateXasida(global::System.Int32 titre, global::System.String tardioumane, global::System.String langue)
        {
            Xasida xasida = new Xasida();
            xasida.Titre = titre;
            xasida.Tardioumane = tardioumane;
            xasida.Langue = langue;
            return xasida;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Titre
        {
            get
            {
                return _Titre;
            }
            set
            {
                if (_Titre != value)
                {
                    OnTitreChanging(value);
                    ReportPropertyChanging("Titre");
                    _Titre = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Titre");
                    OnTitreChanged();
                }
            }
        }
        private global::System.Int32 _Titre;
        partial void OnTitreChanging(global::System.Int32 value);
        partial void OnTitreChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Tardioumane
        {
            get
            {
                return _Tardioumane;
            }
            set
            {
                OnTardioumaneChanging(value);
                ReportPropertyChanging("Tardioumane");
                _Tardioumane = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Tardioumane");
                OnTardioumaneChanged();
            }
        }
        private global::System.String _Tardioumane;
        partial void OnTardioumaneChanging(global::System.String value);
        partial void OnTardioumaneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Langue
        {
            get
            {
                return _Langue;
            }
            set
            {
                OnLangueChanging(value);
                ReportPropertyChanging("Langue");
                _Langue = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Langue");
                OnLangueChanged();
            }
        }
        private global::System.String _Langue;
        partial void OnLangueChanging(global::System.String value);
        partial void OnLangueChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Domain", "XasidaBeyit", "Beyit")]
        public EntityCollection<Beyit> Beyits
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Beyit>("Domain.XasidaBeyit", "Beyit");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Beyit>("Domain.XasidaBeyit", "Beyit", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Domain", "XasidaMole", "Mole")]
        public EntityCollection<Mole> Moles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Mole>("Domain.XasidaMole", "Mole");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Mole>("Domain.XasidaMole", "Mole", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}