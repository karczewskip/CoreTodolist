using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CoreTodoList.DAL;

namespace CoreTodoList.DAL.Migrations
{
    [DbContext(typeof(TodoListContext))]
    [Migration("20170624084521_TodoTasks_added_priority_info")]
    partial class TodoTasks_added_priority_info
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

                    b.Property<bool>("IsPriority");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("TodoTaskId");

                    b.ToTable("TodoTasks");
                });
        }
    }
}
