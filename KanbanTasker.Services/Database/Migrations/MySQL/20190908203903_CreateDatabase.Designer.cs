﻿// <auto-generated />
using KanbanTasker.Services.Database.Components.MySQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KanbanTasker.Services.Database.Migrations.MySQL
{
    [DbContext(typeof(Db_MySQL))]
    [Migration("20190908203903_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("KanbanTasker.Model.BoardDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.HasKey("Id");

                    b.ToTable("tblBoards");
                });

            modelBuilder.Entity("KanbanTasker.Model.TaskDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BoardId");

                    b.Property<string>("Category");

                    b.Property<string>("ColorKey");

                    b.Property<int>("ColumnIndex");

                    b.Property<string>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("BoardId");

                    b.ToTable("tblTasks");
                });

            modelBuilder.Entity("KanbanTasker.Model.TaskDTO", b =>
                {
                    b.HasOne("KanbanTasker.Model.BoardDTO", "Board")
                        .WithMany("Tasks")
                        .HasForeignKey("BoardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
