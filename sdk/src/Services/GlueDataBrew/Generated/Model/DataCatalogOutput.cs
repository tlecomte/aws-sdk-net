/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents options that specify how and where in the Glue Data Catalog DataBrew writes
    /// the output generated by recipe jobs.
    /// </summary>
    public partial class DataCatalogOutput
    {
        private string _catalogId;
        private string _databaseName;
        private DatabaseTableOutputOptions _databaseOptions;
        private bool? _overwrite;
        private S3TableOutputOptions _s3Options;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The unique identifier of the Amazon Web Services account that holds the Data Catalog
        /// that stores the data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of a database in the Data Catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseOptions. 
        /// <para>
        /// Represents options that specify how and where DataBrew writes the database output
        /// generated by recipe jobs.
        /// </para>
        /// </summary>
        public DatabaseTableOutputOptions DatabaseOptions
        {
            get { return this._databaseOptions; }
            set { this._databaseOptions = value; }
        }

        // Check to see if DatabaseOptions property is set
        internal bool IsSetDatabaseOptions()
        {
            return this._databaseOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Overwrite. 
        /// <para>
        /// A value that, if true, means that any data in the location specified for output is
        /// overwritten with new output. Not supported with DatabaseOptions.
        /// </para>
        /// </summary>
        public bool Overwrite
        {
            get { return this._overwrite.GetValueOrDefault(); }
            set { this._overwrite = value; }
        }

        // Check to see if Overwrite property is set
        internal bool IsSetOverwrite()
        {
            return this._overwrite.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3Options. 
        /// <para>
        /// Represents options that specify how and where DataBrew writes the Amazon S3 output
        /// generated by recipe jobs.
        /// </para>
        /// </summary>
        public S3TableOutputOptions S3Options
        {
            get { return this._s3Options; }
            set { this._s3Options = value; }
        }

        // Check to see if S3Options property is set
        internal bool IsSetS3Options()
        {
            return this._s3Options != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of a table in the Data Catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}