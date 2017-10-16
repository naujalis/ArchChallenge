# ArchChallenge

For Windows (working in windows10):
1. Clone this repository
2. Configure Shared Drives on Doker for windows
3. Enable Linux Containers
4. Configure network sharing in file /graylog/docker-compose.yml (lines 6, 11 and 15)
5. Execute docker-compose up -d on /graylog folder
6. Run this application with VS2017

TodoList
------------------------------------------------------------
- Create Custom Property on NLog to TransactionId
- Prevent to send .Net Core information to graylog
- Configure application to use EventId with DI
- Configure Dashboards in Graylog
- Merge docker-compose.yml file of application and Graylog to create a single environment and network isolation