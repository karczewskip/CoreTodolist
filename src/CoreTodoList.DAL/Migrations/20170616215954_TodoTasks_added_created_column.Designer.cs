using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CoreTodoList.DAL;

namespace CoreTodoList.DAL.Migrations
{
    [DbContext(typeof(TodoListContext))]
    [Migration("20170616215954_TodoTasks_added_created_column")]
    partial class TodoTasks_added_created_column
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreTodoList.DAL.Entities.TodoTask", b =>
                {
                    b.Property<int>("TodoTaskId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("TodoTaskId");

                    b.ToTable("TodoTasks");
                });
        }
    }
}
