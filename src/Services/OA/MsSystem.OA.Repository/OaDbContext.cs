﻿using JadeFramework.Dapper.DbContext;
using JadeFramework.Dapper.SqlGenerator;
using MsSystem.OA.IRepository;
using MySql.Data.MySqlClient;

namespace MsSystem.OA.Repository
{
    public class OaDbContext : DapperDbContext, IOaDbContext
    {
        private readonly SqlGeneratorConfig _config = new SqlGeneratorConfig
        {
            SqlConnector = ESqlConnector.MySQL,
            UseQuotationMarks = true
        };
        public OaDbContext(string connectionString)
            : base(new MySqlConnection(connectionString))
        {

        }

        private IOaLeaveRepository _oaLeave;
        public IOaLeaveRepository OaLeaveRepository => _oaLeave ?? (_oaLeave = new OaLeaveRepository(Connection, _config));

        private IOaMessageRepository _oaMessage;
        public IOaMessageRepository OaMessage => _oaMessage ?? (_oaMessage = new OaMessageRepository(Connection, _config));
        private IOaMessageUserReadRepository _messageUserRead;
        public IOaMessageUserReadRepository OaMessageUserRead => _messageUserRead ?? (_messageUserRead = new OaMessageUserReadRepository(Connection, _config));
        private IOaMessageUserRepository _messageUser;
        public IOaMessageUserRepository OaMessageUser => _messageUser ?? (_messageUser = new OaMessageUserRepository(Connection, _config));

        private IOaWorkflowsqlRepository _workflowsql;
        public IOaWorkflowsqlRepository OaWorkflowsql => _workflowsql ?? (_workflowsql = new OaWorkflowsqlRepository(Connection, _config));

    }
}
