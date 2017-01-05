﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Platformus.Infrastructure;

namespace Platformus.ECommerce
{
  public class BackendMetadata : BackendMetadataBase
  {
    public override IEnumerable<BackendMenuGroup> BackendMenuGroups
    {
      get
      {
        return new BackendMenuGroup[]
        {
        };
      }
    }
  }
}