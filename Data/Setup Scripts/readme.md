Contains database setup scripts for local testing

- `wait.cmd` : helper script to pause caller till specific string not found in docker logs. Accepts docker image name and string to look for
- `wait-err.cmd` : helper script to pause caller till specific string not found in docker error logs. Accepts docker image name and string to look for

### Linux (WSL2) images

- `all.cmd` : Windows script to create or update docker containers with all the instances below
- `clickhouse.cmd` : Windows script to create or update docker container with ClickHouse instance
- `db2.cmd` : Windows script to create or update docker container with DB2 instance
- `firebird25.cmd` : Windows script to create or update docker container with FFirebird 2.5 instance
- `firebird30.cmd` : Windows script to create or update docker container with FFirebird 3.0 instance
- `firebird40.cmd` : Windows script to create or update docker container with FFirebird 4.0 instance
- `informix.cmd` : Windows script to create or update docker container with Informix instance
- `mariadb.cmd` : Windows script to create or update docker container with MariaDB instance
- `mysql55.cmd` : Windows script to create or update docker container with MySQL 5.5 instance
- `mysql80.cmd` : Windows script to create or update docker container with latest MySQL 8.x instance
- `oracle11.cmd` : Windows script to create or update docker container with Oracle 11 instance
- `oracle12.cmd` : Windows script to create or update docker container with Oracle 12 instance
- `oracle18.cmd` : Windows script to create or update docker container with Oracle 18 instance
- `oracle19.cmd` : Windows script to create or update docker container with Oracle 19 instance
- `oracle21.cmd` : Windows script to create or update docker container with Oracle 21 instance
- `oracle23.cmd` : Windows script to create or update docker container with Oracle 23 instance
- `pgsql92.cmd` : Windows script to create or update docker container with PostgreSQL 9.2 instance
- `pgsql93.cmd` : Windows script to create or update docker container with PostgreSQL 9.3 instance
- `pgsql95.cmd` : Windows script to create or update docker container with PostgreSQL 9.5 instance
- `pgsql10.cmd` : Windows script to create or update docker container with PostgreSQL 10 instance
- `pgsql11.cmd` : Windows script to create or update docker container with PostgreSQL 11 instance
- `pgsql12.cmd` : Windows script to create or update docker container with PostgreSQL 12 instance
- `pgsql13.cmd` : Windows script to create or update docker container with PostgreSQL 13 instance
- `pgsql14.cmd` : Windows script to create or update docker container with PostgreSQL 14 instance
- `pgsql15.cmd` : Windows script to create or update docker container with PostgreSQL 15 instance
- `saphana2.cmd` : Windows script to create or update docker container with SAP HANA 2 instance
- `sqlserver2017.cmd` : Windows script to create or update docker container with SQL Server 2017 (Linux-based) instance
- `sqlserver2019.cmd` : Windows script to create or update docker container with SQL Server 2019 (Linux-based) instance (also creates databases for FTS, Contained and SequentialAccess test providers)
- `sqlserver2022.cmd` : Windows script to create or update docker container with SQL Server 2022 (Linux-based) instance
- `sybase-ase.cmd` : Windows script to create or update docker container with Sybase ASE instance

### Windows images

Use of Windows-based images is not recommended as they probably will not work due to base image mismatch.

- `sqlserver2022-win.cmd` : Windows script to create or update docker container with SQL Server 2022 (Windows-based) instance
