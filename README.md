# Challenge - ForaFinServices

The following project is a POC solution for a Fora Financial API that supports the following functions:
- Load company info data based on a CIK data source
- Gets fundable amount data for all or requested companies

**Run the app** - Once the app is running, utilize swagger UI to load the company info data to cache (PUT) and then execute subsequent calls to retrieve fundable amount results (GET) for filtered or all loaded companies. You can also use the ForaFinServices.http file to execute these commands while its running.

## Project Notables

**Data Source** - The CIK source is in a csv file and the company info data is persisted in memory cache. 

**API Service** - Bootstraps local services and config sections that support application behavior.

**App Services** - The FundableAmountService commmuncates with the CikDataService to read CIK data and the CompanyInfoCacheService to persist company info data to cache and get company info data upon request.

**Extension methods** - Extension methods power the business/domain logic on the models to calculate values.

**Unit tests** - Suite of tests that provide coverage for the use cases described in the requirements.

**Cache Refresh Options** - Added cache refresh settings to periodically load company info data to cache as part of the API pipeline startup. This automation will add load time to the API start up, but will increase availability for API requests. The PUT can still update the cache manually if necessary.

**Retry resilience** - Added Polly to handle the SEC's Traffic Limit policy. 

**Loading optimization and scaling** - Off-loaded work by messaging commands and events, which decoupled controller from services using handlers. This allows us to position our handlers into individual, separate processes in the future.

**General additions** - Outsourced more values onto settings, optimized parallel processing for cache data and added a  QueueService to handle messaging of Commands and Events

![LoadData-Workflow-2](https://github.com/user-attachments/assets/3e7ed0c5-91e5-440a-a1b2-51ac052e7a9d)

**Robust rule processing** - Made rule processing a bit more flexible and increased maintainability. Added a SpecialFundableRule service that loads each ISpecialFundableRule rule in the system. This will allow for new Special Fundable Amount rules to seamlessly incorporate into the workflow without modifying core, domain logic.

## Frontend Integration

**Company Info Viewer** - Added a front end application that allows user to review company info resources and unit data. The UI features paged company info data, filterable resources and on-demand fundable amount calculation. Find the client project [here](https://github.com/andresmolivares/fora-fin-viewer).

## Future Updates

**Persisting CIK Data** - CIK data is currently read from file behind an API endpoint, but we can persist CIK data into a database for faul-tolerant access with scheduled reads and cache updates.

**Cache Updates** - Cache Refresh Options has improved data availability but, we can still leverage persistant, distributed solutions to keep company info data up-to-date, i.e. Hangfire, Redis.

