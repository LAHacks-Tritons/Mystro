<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="CService" generation="1" functional="0" release="0" Id="6815abe3-bb11-4da0-ac13-504bf866a6ee" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="CServiceGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="WRole:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/CService/CServiceGroup/LB:WRole:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="WRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/CService/CServiceGroup/MapWRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="WRoleInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/CService/CServiceGroup/MapWRoleInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:WRole:Endpoint1">
          <toPorts>
            <inPortMoniker name="/CService/CServiceGroup/WRole/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapWRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/CService/CServiceGroup/WRole/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapWRoleInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/CService/CServiceGroup/WRoleInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="WRole" generation="1" functional="0" release="0" software="C:\Users\jmartinez\Source\Workspaces\Newstein Education\CloudService.NewsteinEducation\CService\csx\Debug\roles\WRole" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="1792" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;WRole&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;WRole&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/CService/CServiceGroup/WRoleInstances" />
            <sCSPolicyUpdateDomainMoniker name="/CService/CServiceGroup/WRoleUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/CService/CServiceGroup/WRoleFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="WRoleUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="WRoleFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="WRoleInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="b3b2abea-1541-442e-9e97-bcd5a17a3258" ref="Microsoft.RedDog.Contract\ServiceContract\CServiceContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="ac3aa5e3-ae03-48ea-a4ae-d80068d19c80" ref="Microsoft.RedDog.Contract\Interface\WRole:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/CService/CServiceGroup/WRole:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>