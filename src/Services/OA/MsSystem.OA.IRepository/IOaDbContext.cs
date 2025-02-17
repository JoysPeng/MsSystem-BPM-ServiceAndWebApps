﻿using JadeFramework.Dapper.DbContext;

namespace MsSystem.OA.IRepository
{
    public interface IOaDbContext: IDapperDbContext
    {
        IOaLeaveRepository OaLeaveRepository { get; }

        IOaMessageRepository OaMessage { get; }
        IOaMessageUserReadRepository OaMessageUserRead { get; }
        IOaMessageUserRepository OaMessageUser { get; }
        IOaWorkflowsqlRepository OaWorkflowsql { get; }
    }
}
