﻿using System;

namespace Chloe.DbExpressions
{
    /// <summary>
    /// 完整的列  T.Name as Alias
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Alias = {Alias}")]
    public class DbColumnSegmentExpression : DbExpression
    {
        DbExpression _body;
        string _alias;

        public DbColumnSegmentExpression(Type type, DbExpression body, string alias)
            : base(DbExpressionType.ColumnSegment, type)
        {
            this._body = body;
            this._alias = alias;
        }

        /// <summary>
        /// T.Name 部分
        /// </summary>
        public DbExpression Body { get { return this._body; } }
        public string Alias { get { return this._alias; } }

        public override T Accept<T>(DbExpressionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }

    }
}