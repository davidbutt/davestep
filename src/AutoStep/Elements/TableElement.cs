﻿using System.Collections.Generic;

namespace AutoStep.Elements
{
    /// <summary>
    /// Represents a table built from autostep source.
    /// </summary>
    public class TableElement : BuiltElement
    {
        private List<TableRowElement> rows = new List<TableRowElement>();

        /// <summary>
        /// Gets the header row.
        /// </summary>
        public TableHeaderElement Header { get; } = new TableHeaderElement();

        /// <summary>
        /// Gets the number of columns expected in the table (based on the number of headers).
        /// </summary>
        public int ColumnCount => Header?.Headers.Count ?? 0;

        /// <summary>
        /// Gets the non-header rows in the table.
        /// </summary>
        public IReadOnlyList<TableRowElement> Rows => rows;

        /// <summary>
        /// Adds a row to the table.
        /// </summary>
        /// <param name="row">The row.</param>
        public void AddRow(TableRowElement row)
        {
            rows.Add(row);
        }
    }
}
