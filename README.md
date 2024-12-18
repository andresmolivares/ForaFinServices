# Challenge - ForaFinServices

The following project is a POC solution for a Fora Financial API that supports the following functions:
- Load company info data based on a CIK data source
- Gets fundable amount data for all or requested companies

**Run the app** - Once the app is running, utilize swagger UI to load the company info data to cache (PUT) and then execute subsequent calls to retrieve fundable amount results (GET) for filtered or all loaded companies. You can also use the ForaFinServices.http to execute these commands.

## Project Notables

**Data Source** - The CIK source is in a csv file and the company info data is persisted in memory cache. 

**API Service** - Bootstraps local services and config sections that support application behavior.

**App Services** - The FundableAmountService commmuncates with the CikRepositoryService and the SecCompanyInfoService to read CIK data and persist company info data to cache, and get company info data upon request, respectively.

**Extension methods** - Extension methods power the business/domain logic on the models to calculate values.

**Unit tests** - Suite of tests that provide coverage for the use cases described in the requirements.

**Workflow** - Company info repository is updated at a configured interval to support requests for fundable data. We can add a background process to keep company info data up-to-date when the CIK source changes, i.e. Hangfire, Redis.
