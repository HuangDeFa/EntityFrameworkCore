﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;

namespace Microsoft.Data.Entity.Relational.Migrations.Operations
{
    public class SqlOperation : MigrationOperation
    {
        public virtual string Sql { get;[param: NotNull] set; }
        public virtual bool SuppressTransaction { get; set; }
    }
}
