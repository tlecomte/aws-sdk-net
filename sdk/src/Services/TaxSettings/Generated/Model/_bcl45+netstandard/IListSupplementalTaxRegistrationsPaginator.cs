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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
 */
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// Paginator for the ListSupplementalTaxRegistrations operation
    ///</summary>
    public interface IListSupplementalTaxRegistrationsPaginator
    {
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        IPaginatedEnumerable<ListSupplementalTaxRegistrationsResponse> Responses { get; }

        /// <summary>
        /// Enumerable containing all of the TaxRegistrations
        /// </summary>
        IPaginatedEnumerable<SupplementalTaxRegistration> TaxRegistrations { get; }
    }
}