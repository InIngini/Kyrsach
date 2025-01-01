﻿namespace Курсач.Data.Entities
{
    /// <summary>
    /// Класс, представляющий связь между пользователем и книгой.
    /// </summary>
    public class BelongToBook
    {
        /// <summary>
        /// Уникальный идентификатор пользователя.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Связанный пользователь.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Уникальный идентификатор книги.
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Связанная книга.
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// Тип принадлежности (например, прочитанная, в библиотеке и т.д.).
        /// </summary>
        public int TypeBelong { get; set; }
    }

}
