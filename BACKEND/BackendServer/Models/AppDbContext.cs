using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BackendServer.Repositorios;
namespace BackendServer.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        Connexion connString = new Connexion();
        public virtual DbSet<Actividad> Actividad { get; set; }
        public virtual DbSet<Amigo> Amigo { get; set; }
        public virtual DbSet<Carrera> Carrera { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<CategoriaCarrera> CategoriaCarrera { get; set; }
        public virtual DbSet<Deportista> Deportista { get; set; }
        public virtual DbSet<DeportistaGrupo> DeportistaGrupo { get; set; }
        public virtual DbSet<DeportistaReto> DeportistaReto { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<GrupoCarrera> GrupoCarrera { get; set; }
        public virtual DbSet<GrupoReto> GrupoReto { get; set; }
        public virtual DbSet<Inscripcion> Inscripcion { get; set; }
        public virtual DbSet<Organizador> Organizador { get; set; }
        public virtual DbSet<Patrocinador> Patrocinador { get; set; }
        public virtual DbSet<PatrocinadorCarrera> PatrocinadorCarrera { get; set; }
        public virtual DbSet<PatrocinadorReto> PatrocinadorReto { get; set; }
        public virtual DbSet<Reto> Reto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql(connString.conexion);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Actividad>(entity =>
            {
                
                entity.HasKey(e => e.IdActividad)
                    .HasName("actividad_pkey");

                entity.ToTable("actividad", "proyecto1");

                entity.Property(e => e.IdActividad).HasColumnName("id_actividad");

                entity.Property(e => e.Completitud)
                    .HasColumnName("completitud")
                    .HasMaxLength(8);

                entity.Property(e => e.Duracion)
                    .HasColumnName("duracion")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Hora)
                    .HasColumnName("hora")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.IdDeportista)
                    .IsRequired()
                    .HasColumnName("id_deportista")
                    .HasColumnType("character varying");

                entity.Property(e => e.Kilometros).HasColumnName("kilometros");

                entity.Property(e => e.Mapa)
                    .HasColumnName("mapa")
                    .HasColumnType("character varying");

                entity.Property(e => e.Nombreactividad)
                    .IsRequired()
                    .HasColumnName("nombreactividad")
                    .HasColumnType("character varying");

                entity.Property(e => e.TipoActividad)
                    .IsRequired()
                    .HasColumnName("tipo_actividad")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("ROW('Correr', 'Nadar', 'Ciclismo', 'Senderistmo', 'Kayak', 'Caminata')");
                /*
                entity.HasOne(d => d.IdDeportistaNavigation)
                    .WithMany(p => p.Actividad)
                    .HasForeignKey(d => d.IdDeportista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("actividad_id_deportista_fkey");
                */
            });

            modelBuilder.Entity<Amigo>(entity =>
            {
                entity.HasKey(e => new { e.Deportista, e.Amigo1 })
                    .HasName("amigo_pkey");

                entity.ToTable("amigo", "proyecto1");

                entity.Property(e => e.Deportista)
                    .HasColumnName("deportista")
                    .HasColumnType("character varying");

                entity.Property(e => e.Amigo1)
                    .HasColumnName("amigo")
                    .HasColumnType("character varying");
                /*
                entity.HasOne(d => d.Amigo1Navigation)
                    .WithMany(p => p.AmigoAmigo1Navigation)
                    .HasForeignKey(d => d.Amigo1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("amigo_amigo_fkey");

                entity.HasOne(d => d.DeportistaNavigation)
                    .WithMany(p => p.AmigoDeportistaNavigation)
                    .HasForeignKey(d => d.Deportista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("amigo_deportista_fkey");
                */
            });

            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.HasKey(e => e.IdCarrera)
                    .HasName("carrera_pkey");

                entity.ToTable("carrera", "proyecto1");

                entity.HasIndex(e => new { e.IdCarrera, e.IdOrganizador })
                    .HasName("carrera_id_carrera_id_organizador_key")
                    .IsUnique();

                entity.Property(e => e.IdCarrera).HasColumnName("id_carrera");

                entity.Property(e => e.Costo)
                    .HasColumnName("costo")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.Cuenta)
                    .HasColumnName("cuenta")
                    .HasColumnType("numeric(20,0)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.IdOrganizador)
                    .IsRequired()
                    .HasColumnName("id_organizador")
                    .HasColumnType("character varying");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying");

                entity.Property(e => e.Privacidad).HasColumnName("privacidad");

                entity.Property(e => e.Recorrido)
                    .IsRequired()
                    .HasColumnName("recorrido")
                    .HasColumnType("character varying");

                entity.Property(e => e.TipoActividad)
                    .IsRequired()
                    .HasColumnName("tipo_actividad")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("ROW('Correr', 'Nadar', 'Ciclismo', 'Senderistmo', 'Kayak', 'Caminata')");

                entity.HasOne(d => d.IdOrganizadorNavigation)
                    .WithMany(p => p.Carrera)
                    .HasForeignKey(d => d.IdOrganizador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("carrera_id_organizador_fkey");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("categoria_pkey");

                entity.ToTable("categoria", "proyecto1");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(30);

                entity.Property(e => e.NombreCategoria)
                    .IsRequired()
                    .HasColumnName("nombre_categoria")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<CategoriaCarrera>(entity =>
            {
                entity.HasKey(e => new { e.IdCarrera, e.IdCategoria })
                    .HasName("categoria_carrera_pkey");

                entity.ToTable("categoria_carrera", "proyecto1");

                entity.Property(e => e.IdCarrera).HasColumnName("id_carrera");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.HasOne(d => d.IdCarreraNavigation)
                    .WithMany(p => p.CategoriaCarrera)
                    .HasForeignKey(d => d.IdCarrera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("categoria_carrera_id_carrera_fkey");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.CategoriaCarrera)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("categoria_carrera_id_categoria_fkey");
            });

            modelBuilder.Entity<Deportista>(entity =>
            {
                entity.HasKey(e => e.usuariodep)
                    .HasName("deportista_pkey");

                entity.ToTable("deportista", "proyecto1");

                entity.Property(e => e.usuariodep)
                    .HasColumnName("usuario_dep")
                    .HasMaxLength(10);

                entity.Property(e => e.apellido1)
                    .HasColumnName("apellido1")
                    .HasMaxLength(15);

                entity.Property(e => e.apellido2)
                    .HasColumnName("apellido2")
                    .HasMaxLength(15);

                entity.Property(e => e.clave)
                    .IsRequired()
                    .HasColumnName("clave")
                    .HasMaxLength(12);

                entity.Property(e => e.fecnac)
                    .HasColumnName("fecnac")
                    .HasColumnType("date");

                entity.Property(e => e.foto)
                    .HasColumnName("foto")
                    .HasColumnType("character varying");

                entity.Property(e => e.nacionalidad)
                    .HasColumnName("nacionalidad")
                    .HasMaxLength(15);

                entity.Property(e => e.primernombre)
                    .HasColumnName("primer_nombre")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<DeportistaGrupo>(entity =>
            {
                entity.HasKey(e => new { e.UsuarioDep, e.IdGrupo })
                    .HasName("deportista_grupo_pkey");

                entity.ToTable("deportista_grupo", "proyecto1");

                entity.Property(e => e.UsuarioDep)
                    .HasColumnName("usuario_dep")
                    .HasColumnType("character varying");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");

                /*
                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.DeportistaGrupo)
                    .HasForeignKey(d => d.IdGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deportista_grupo_id_grupo_fkey");
                
                entity.HasOne(d => d.UsuarioDepNavigation)
                    .WithMany(p => p.DeportistaGrupo)
                    .HasForeignKey(d => d.UsuarioDep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deportista_grupo_usuario_dep_fkey");
                */
            });

            modelBuilder.Entity<DeportistaReto>(entity =>
            {
                entity.HasKey(e => new { e.UsuarioDep, e.IdReto })
                    .HasName("deportista_reto_pkey");

                entity.ToTable("deportista_reto", "proyecto1");

                entity.Property(e => e.UsuarioDep)
                    .HasColumnName("usuario_dep")
                    .HasColumnType("character varying");

                entity.Property(e => e.IdReto).HasColumnName("id_reto");

                /*
                entity.HasOne(d => d.IdRetoNavigation)
                    .WithMany(p => p.DeportistaReto)
                    .HasForeignKey(d => d.IdReto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deportista_reto_id_reto_fkey");
                
                entity.HasOne(d => d.UsuarioDepNavigation)
                    .WithMany(p => p.DeportistaReto)
                    .HasForeignKey(d => d.UsuarioDep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deportista_reto_usuario_dep_fkey");
                */
            });

            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.HasKey(e => e.IdGrupo)
                    .HasName("grupo_pkey");

                entity.ToTable("grupo", "proyecto1");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");

                entity.Property(e => e.Administrador)
                    .IsRequired()
                    .HasColumnName("administrador")
                    .HasColumnType("character varying");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.AdministradorNavigation)
                    .WithMany(p => p.Grupo)
                    .HasForeignKey(d => d.Administrador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupo_administrador_fkey");
            });

            modelBuilder.Entity<GrupoCarrera>(entity =>
            {
                entity.HasKey(e => new { e.IdGrupo, e.IdCarrera })
                    .HasName("grupo_carrera_pkey");

                entity.ToTable("grupo_carrera", "proyecto1");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");

                entity.Property(e => e.IdCarrera).HasColumnName("id_carrera");

                entity.HasOne(d => d.IdCarreraNavigation)
                    .WithMany(p => p.GrupoCarrera)
                    .HasForeignKey(d => d.IdCarrera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupo_carrera_id_carrera_fkey");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.GrupoCarrera)
                    .HasForeignKey(d => d.IdGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupo_carrera_id_grupo_fkey");
            });

            modelBuilder.Entity<GrupoReto>(entity =>
            {
                entity.HasKey(e => new { e.IdGrupo, e.IdReto })
                    .HasName("grupo_reto_pkey");

                entity.ToTable("grupo_reto", "proyecto1");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");

                entity.Property(e => e.IdReto).HasColumnName("id_reto");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.GrupoReto)
                    .HasForeignKey(d => d.IdGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupo_reto_id_grupo_fkey");

                entity.HasOne(d => d.IdRetoNavigation)
                    .WithMany(p => p.GrupoReto)
                    .HasForeignKey(d => d.IdReto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupo_reto_id_reto_fkey");
            });

            modelBuilder.Entity<Inscripcion>(entity =>
            {
                entity.HasKey(e => new { e.IdInscripcion, e.IdCarrera, e.UsuarioDep })
                    .HasName("inscripcion_pkey");

                entity.ToTable("inscripcion", "proyecto1");

                entity.Property(e => e.IdInscripcion)
                    .HasColumnName("id_inscripcion")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdCarrera).HasColumnName("id_carrera");

                entity.Property(e => e.UsuarioDep)
                    .HasColumnName("usuario_dep")
                    .HasColumnType("character varying");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasColumnName("categoria")
                    .HasMaxLength(10);

                entity.Property(e => e.Comprobante)
                    .HasColumnName("comprobante")
                    .HasColumnType("character varying");
                /*
                entity.HasOne(d => d.IdCarreraNavigation)
                    .WithMany(p => p.Inscripcion)
                    .HasForeignKey(d => d.IdCarrera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("inscripcion_id_carrera_fkey");

                entity.HasOne(d => d.UsuarioDepNavigation)
                    .WithMany(p => p.Inscripcion)
                    .HasForeignKey(d => d.UsuarioDep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("inscripcion_usuario_dep_fkey");
                */
            });

            modelBuilder.Entity<Organizador>(entity =>
            {
                entity.HasKey(e => e.UsuarioOrg)
                    .HasName("organizador_pkey");

                entity.ToTable("organizador", "proyecto1");

                entity.Property(e => e.UsuarioOrg)
                    .HasColumnName("usuario_org")
                    .HasMaxLength(10);

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasColumnName("apellido1")
                    .HasMaxLength(15);

                entity.Property(e => e.Apellido2)
                    .HasColumnName("apellido2")
                    .HasMaxLength(15);

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasColumnName("clave")
                    .HasMaxLength(15);

                entity.Property(e => e.Fecnac)
                    .HasColumnName("fecnac")
                    .HasColumnType("date");

                entity.Property(e => e.Foto)
                    .HasColumnName("foto")
                    .HasColumnType("character varying");

                entity.Property(e => e.Nacionalidad)
                    .HasColumnName("nacionalidad")
                    .HasMaxLength(15);

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasColumnName("primer_nombre")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Patrocinador>(entity =>
            {
                entity.HasKey(e => e.IdPatrocinador)
                    .HasName("patrocinador_pkey");

                entity.ToTable("patrocinador", "proyecto1");

                entity.Property(e => e.IdPatrocinador).HasColumnName("id_patrocinador");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasColumnType("character varying");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(15);

                entity.Property(e => e.Numrepresentante)
                    .HasColumnName("numrepresentante")
                    .HasColumnType("numeric(20,0)");

                entity.Property(e => e.Representante)
                    .IsRequired()
                    .HasColumnName("representante")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PatrocinadorCarrera>(entity =>
            {
                entity.HasKey(e => new { e.IdCarrera, e.IdPatrocinador })
                    .HasName("patrocinador_carrera_pkey");

                entity.ToTable("patrocinador_carrera", "proyecto1");

                entity.Property(e => e.IdCarrera).HasColumnName("id_carrera");

                entity.Property(e => e.IdPatrocinador).HasColumnName("id_patrocinador");

                entity.HasOne(d => d.IdCarreraNavigation)
                    .WithMany(p => p.PatrocinadorCarrera)
                    .HasForeignKey(d => d.IdCarrera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patrocinador_carrera_id_carrera_fkey");

                entity.HasOne(d => d.IdPatrocinadorNavigation)
                    .WithMany(p => p.PatrocinadorCarrera)
                    .HasForeignKey(d => d.IdPatrocinador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patrocinador_carrera_id_patrocinador_fkey");
            });

            modelBuilder.Entity<PatrocinadorReto>(entity =>
            {
                entity.HasKey(e => new { e.IdPatrocinador, e.IdReto })
                    .HasName("patrocinador_reto_pkey");

                entity.ToTable("patrocinador_reto", "proyecto1");

                entity.Property(e => e.IdPatrocinador).HasColumnName("id_patrocinador");

                entity.Property(e => e.IdReto).HasColumnName("id_reto");

                entity.HasOne(d => d.IdPatrocinadorNavigation)
                    .WithMany(p => p.PatrocinadorReto)
                    .HasForeignKey(d => d.IdPatrocinador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patrocinador_reto_id_patrocinador_fkey");

                entity.HasOne(d => d.IdRetoNavigation)
                    .WithMany(p => p.PatrocinadorReto)
                    .HasForeignKey(d => d.IdReto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patrocinador_reto_id_reto_fkey");
            });

            modelBuilder.Entity<Reto>(entity =>
            {
                entity.HasKey(e => e.IdReto)
                    .HasName("reto_pkey");

                entity.ToTable("reto", "proyecto1");

                entity.HasIndex(e => new { e.IdReto, e.IdOrganizador })
                    .HasName("reto_id_reto_id_organizador_key")
                    .IsUnique();

                entity.Property(e => e.IdReto).HasColumnName("id_reto");

                entity.Property(e => e.IdOrganizador)
                    .IsRequired()
                    .HasColumnName("id_organizador")
                    .HasColumnType("character varying");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying");

                entity.Property(e => e.Periodo)
                    .HasColumnName("periodo")
                    .HasColumnType("date");

                entity.Property(e => e.Privacidad).HasColumnName("privacidad");

                entity.Property(e => e.TipoActividad)
                    .IsRequired()
                    .HasColumnName("tipo_actividad")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("ROW('Correr', 'Nadar', 'Ciclismo', 'Senderistmo', 'Kayak', 'Caminata')");

                entity.Property(e => e.TipoReto)
                    .HasColumnName("tipo_reto")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("ROW('Altitud', 'Fondo')");

                entity.HasOne(d => d.IdOrganizadorNavigation)
                    .WithMany(p => p.Reto)
                    .HasForeignKey(d => d.IdOrganizador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reto_id_organizador_fkey");
            
            });
            
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
