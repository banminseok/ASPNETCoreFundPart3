using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNote.Angular.Components
{
    public class TodoComponent
    {
        //
    }

    /// <summary>
    /// todo 모델 클래스 : Todos 테이블
    /// </summary>
    public class Todo {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; } = false;
    }

    /// <summary>
    /// Todo 컨텍스트 클래슨
    /// </summary>
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; }
    }

    public interface ITodoRepository
    {

    }

    public class TodoRepository : ITodoRepository
    {

    }
}
