﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CDato.Base
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mardis_wp3Entities : DbContext
    {
        public mardis_wp3Entities()
            : base("name=mardis_wp3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<wp_commentmeta> wp_commentmeta { get; set; }
        public virtual DbSet<wp_comments> wp_comments { get; set; }
        public virtual DbSet<wp_fch_nomenclatura> wp_fch_nomenclatura { get; set; }
        public virtual DbSet<wp_links> wp_links { get; set; }
        public virtual DbSet<wp_novedad> wp_novedad { get; set; }
        public virtual DbSet<wp_options> wp_options { get; set; }
        public virtual DbSet<wp_postmeta> wp_postmeta { get; set; }
        public virtual DbSet<wp_posts> wp_posts { get; set; }
        public virtual DbSet<wp_term_relationships> wp_term_relationships { get; set; }
        public virtual DbSet<wp_term_taxonomy> wp_term_taxonomy { get; set; }
        public virtual DbSet<wp_termmeta> wp_termmeta { get; set; }
        public virtual DbSet<wp_terms> wp_terms { get; set; }
        public virtual DbSet<wp_tpo_novedad> wp_tpo_novedad { get; set; }
        public virtual DbSet<wp_usermeta> wp_usermeta { get; set; }
        public virtual DbSet<wp_users> wp_users { get; set; }
        public virtual DbSet<wp_users_valid> wp_users_valid { get; set; }
        public virtual DbSet<wp_woocommerce_api_keys> wp_woocommerce_api_keys { get; set; }
        public virtual DbSet<wp_woocommerce_attribute_taxonomies> wp_woocommerce_attribute_taxonomies { get; set; }
        public virtual DbSet<wp_woocommerce_downloadable_product_permissions> wp_woocommerce_downloadable_product_permissions { get; set; }
        public virtual DbSet<wp_woocommerce_log> wp_woocommerce_log { get; set; }
        public virtual DbSet<wp_woocommerce_order_itemmeta> wp_woocommerce_order_itemmeta { get; set; }
        public virtual DbSet<wp_woocommerce_order_items> wp_woocommerce_order_items { get; set; }
        public virtual DbSet<wp_woocommerce_payment_tokenmeta> wp_woocommerce_payment_tokenmeta { get; set; }
        public virtual DbSet<wp_woocommerce_payment_tokens> wp_woocommerce_payment_tokens { get; set; }
        public virtual DbSet<wp_woocommerce_sessions> wp_woocommerce_sessions { get; set; }
        public virtual DbSet<wp_woocommerce_shipping_zone_locations> wp_woocommerce_shipping_zone_locations { get; set; }
        public virtual DbSet<wp_woocommerce_shipping_zone_methods> wp_woocommerce_shipping_zone_methods { get; set; }
        public virtual DbSet<wp_woocommerce_shipping_zones> wp_woocommerce_shipping_zones { get; set; }
        public virtual DbSet<wp_woocommerce_tax_rate_locations> wp_woocommerce_tax_rate_locations { get; set; }
        public virtual DbSet<wp_woocommerce_tax_rates> wp_woocommerce_tax_rates { get; set; }
        public virtual DbSet<wp_nf3_action_meta> wp_nf3_action_meta { get; set; }
        public virtual DbSet<wp_nf3_actions> wp_nf3_actions { get; set; }
        public virtual DbSet<wp_nf3_field_meta> wp_nf3_field_meta { get; set; }
        public virtual DbSet<wp_nf3_fields> wp_nf3_fields { get; set; }
        public virtual DbSet<wp_nf3_form_meta> wp_nf3_form_meta { get; set; }
        public virtual DbSet<wp_nf3_forms> wp_nf3_forms { get; set; }
        public virtual DbSet<wp_nf3_object_meta> wp_nf3_object_meta { get; set; }
        public virtual DbSet<wp_nf3_objects> wp_nf3_objects { get; set; }
        public virtual DbSet<wp_nf3_relationships> wp_nf3_relationships { get; set; }
        public virtual DbSet<wp_woof_query_cache> wp_woof_query_cache { get; set; }
    }
}
