﻿namespace Core.CBRWebService
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ServiceModel.ServiceContractAttribute(Namespace = "http://web.cbr.ru/", ConfigurationName = "CBRWebService.DailyInfoSoap")]
	public interface DailyInfoSoap
	{

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SaldoXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode SaldoXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SaldoXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> SaldoXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/ROISfixXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode ROISfixXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/ROISfixXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> ROISfixXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/RuoniaXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode RuoniaXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/RuoniaXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> RuoniaXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/OstatDepoXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode OstatDepoXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/OstatDepoXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> OstatDepoXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/ValIntDayXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode ValIntDayXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/ValIntDayXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> ValIntDayXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/ValIntDay", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet ValIntDay(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/ValIntDay", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> ValIntDayAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/OstatDepo", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet OstatDepo(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/OstatDepo", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> OstatDepoAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/ROISfix", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet ROISfix(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/ROISfix", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> ROISfixAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/Ruonia", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet Ruonia(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/Ruonia", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> RuoniaAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/mrrf7D", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet mrrf7D(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/mrrf7D", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> mrrf7DAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/mrrf7DXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode mrrf7DXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/mrrf7DXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> mrrf7DXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/RepoDebtUSD", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet RepoDebtUSD(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/RepoDebtUSD", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> RepoDebtUSDAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/RepoDebtUSDXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode RepoDebtUSDXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/RepoDebtUSDXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> RepoDebtUSDXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/mrrf", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet mrrf(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/mrrf", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> mrrfAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/mrrfXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode mrrfXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/mrrfXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> mrrfXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/Saldo", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet Saldo(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/Saldo", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> SaldoAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/NewsInfoXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode NewsInfoXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/NewsInfoXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> NewsInfoXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/OmodInfoXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode OmodInfoXML();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/OmodInfoXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> OmodInfoXMLAsync();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/XVol", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet XVol(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/XVol", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> XVolAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/XVolXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode XVolXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/XVolXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> XVolXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/MainInfoXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode MainInfoXML();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/MainInfoXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> MainInfoXMLAsync();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/AllDataInfoXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode AllDataInfoXML();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/AllDataInfoXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> AllDataInfoXMLAsync();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/NewsInfo", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet NewsInfo(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/NewsInfo", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> NewsInfoAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapDayTotal", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet SwapDayTotal(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapDayTotal", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> SwapDayTotalAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapDayTotalXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode SwapDayTotalXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapDayTotalXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> SwapDayTotalXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapDynamicXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode SwapDynamicXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapDynamicXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> SwapDynamicXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapInfoSellUSDVolXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode SwapInfoSellUSDVolXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapInfoSellUSDVolXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> SwapInfoSellUSDVolXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapInfoSellUSDVol", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet SwapInfoSellUSDVol(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapInfoSellUSDVol", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> SwapInfoSellUSDVolAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapInfoSellUSD", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet SwapInfoSellUSD(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapInfoSellUSD", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> SwapInfoSellUSDAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapInfoSellUSDXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode SwapInfoSellUSDXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapInfoSellUSDXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> SwapInfoSellUSDXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/BiCurBaseXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode BiCurBaseXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/BiCurBaseXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> BiCurBaseXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/BiCurBase", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet BiCurBase(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/BiCurBase", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> BiCurBaseAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/BiCurBacketXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode BiCurBacketXML();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/BiCurBacketXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> BiCurBacketXMLAsync();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/BiCurBacket", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet BiCurBacket();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/BiCurBacket", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> BiCurBacketAsync();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapDynamic", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet SwapDynamic(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapDynamic", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> SwapDynamicAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapMonthTotal", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet SwapMonthTotal(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapMonthTotal", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> SwapMonthTotalAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapMonthTotalXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode SwapMonthTotalXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/SwapMonthTotalXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> SwapMonthTotalXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/MKR", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet MKR(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/MKR", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> MKRAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/MKRXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode MKRXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/MKRXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> MKRXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/DV", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet DV(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/DV", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> DVAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/DVXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode DVXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/DVXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> DVXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/Repo_debt", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet Repo_debt(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/Repo_debt", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> Repo_debtAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/Repo_debtXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode Repo_debtXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/Repo_debtXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> Repo_debtXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/Coins_base", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet Coins_base(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/Coins_base", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> Coins_baseAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/Coins_baseXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode Coins_baseXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/Coins_baseXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> Coins_baseXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/FixingBase", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet FixingBase(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/FixingBase", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> FixingBaseAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/FixingBaseXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode FixingBaseXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/FixingBaseXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> FixingBaseXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/Overnight", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet Overnight(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/Overnight", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> OvernightAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/OvernightXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode OvernightXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/OvernightXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> OvernightXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/Bauction", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet Bauction(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/Bauction", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> BauctionAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/BauctionXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode BauctionXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/BauctionXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> BauctionXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/DepoDynamicXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode DepoDynamicXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/DepoDynamicXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> DepoDynamicXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/DepoDynamic", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet DepoDynamic(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/DepoDynamic", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> DepoDynamicAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/OstatDynamicXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode OstatDynamicXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/OstatDynamicXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> OstatDynamicXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/OstatDynamic", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet OstatDynamic(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/OstatDynamic", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> OstatDynamicAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/DragMetDynamicXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode DragMetDynamicXML(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/DragMetDynamicXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> DragMetDynamicXMLAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/DragMetDynamic", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet DragMetDynamic(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/DragMetDynamic", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> DragMetDynamicAsync(System.DateTime fromDate, System.DateTime ToDate);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetLatestDateTime", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.DateTime GetLatestDateTime();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetLatestDateTime", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.DateTime> GetLatestDateTimeAsync();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetLatestDate", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		string GetLatestDate();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetLatestDate", ReplyAction = "*")]
		System.Threading.Tasks.Task<string> GetLatestDateAsync();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetLatestDateTimeSeld", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.DateTime GetLatestDateTimeSeld();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetLatestDateTimeSeld", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.DateTime> GetLatestDateTimeSeldAsync();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetLatestDateSeld", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		string GetLatestDateSeld();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetLatestDateSeld", ReplyAction = "*")]
		System.Threading.Tasks.Task<string> GetLatestDateSeldAsync();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/EnumValutesXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode EnumValutesXML(bool Seld);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/EnumValutesXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> EnumValutesXMLAsync(bool Seld);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/EnumValutes", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet EnumValutes(bool Seld);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/EnumValutes", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> EnumValutesAsync(bool Seld);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetLatestReutersDateTime", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.DateTime GetLatestReutersDateTime();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetLatestReutersDateTime", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.DateTime> GetLatestReutersDateTimeAsync();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/EnumReutersValutesXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode EnumReutersValutesXML();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/EnumReutersValutesXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> EnumReutersValutesXMLAsync();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/EnumReutersValutes", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet EnumReutersValutes();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/EnumReutersValutes", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> EnumReutersValutesAsync();

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetReutersCursOnDateXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode GetReutersCursOnDateXML(System.DateTime On_date);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetReutersCursOnDateXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> GetReutersCursOnDateXMLAsync(System.DateTime On_date);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetReutersCursOnDate", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet GetReutersCursOnDate(System.DateTime On_date);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetReutersCursOnDate", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> GetReutersCursOnDateAsync(System.DateTime On_date);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetReutersCursDynamicXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode GetReutersCursDynamicXML(System.DateTime FromDate, System.DateTime ToDate, int NumCode);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetReutersCursDynamicXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> GetReutersCursDynamicXMLAsync(System.DateTime FromDate, System.DateTime ToDate, int NumCode);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetReutersCursDynamic", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet GetReutersCursDynamic(System.DateTime FromDate, System.DateTime ToDate, int NumCode);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetReutersCursDynamic", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> GetReutersCursDynamicAsync(System.DateTime FromDate, System.DateTime ToDate, int NumCode);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetCursDynamicXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode GetCursDynamicXML(System.DateTime FromDate, System.DateTime ToDate, string ValutaCode);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetCursDynamicXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> GetCursDynamicXMLAsync(System.DateTime FromDate, System.DateTime ToDate, string ValutaCode);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetCursDynamic", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet GetCursDynamic(System.DateTime FromDate, System.DateTime ToDate, string ValutaCode);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetCursDynamic", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> GetCursDynamicAsync(System.DateTime FromDate, System.DateTime ToDate, string ValutaCode);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetCursOnDateXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode GetCursOnDateXML(System.DateTime On_date);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetCursOnDateXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> GetCursOnDateXMLAsync(System.DateTime On_date);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetSeldCursOnDateXML", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Xml.XmlNode GetSeldCursOnDateXML(System.DateTime On_date);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetSeldCursOnDateXML", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Xml.XmlNode> GetSeldCursOnDateXMLAsync(System.DateTime On_date);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetSeldCursOnDate", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet GetSeldCursOnDate(System.DateTime On_date);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetSeldCursOnDate", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> GetSeldCursOnDateAsync(System.DateTime On_date);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetCursOnDate", ReplyAction = "*")]
		[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
		System.Data.DataSet GetCursOnDate(System.DateTime On_date);

		[System.ServiceModel.OperationContractAttribute(Action = "http://web.cbr.ru/GetCursOnDate", ReplyAction = "*")]
		System.Threading.Tasks.Task<System.Data.DataSet> GetCursOnDateAsync(System.DateTime On_date);
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	public interface DailyInfoSoapChannel : CBRWebService.DailyInfoSoap, System.ServiceModel.IClientChannel
	{
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	public partial class DailyInfoSoapClient : System.ServiceModel.ClientBase<CBRWebService.DailyInfoSoap>, CBRWebService.DailyInfoSoap
	{

		public DailyInfoSoapClient()
		{
		}

		public DailyInfoSoapClient(string endpointConfigurationName) :
				base(endpointConfigurationName)
		{
		}

		public DailyInfoSoapClient(string endpointConfigurationName, string remoteAddress) :
				base(endpointConfigurationName, remoteAddress)
		{
		}

		public DailyInfoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
				base(endpointConfigurationName, remoteAddress)
		{
		}

		public DailyInfoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
				base(binding, remoteAddress)
		{
		}

		public System.Xml.XmlNode SaldoXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SaldoXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> SaldoXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SaldoXMLAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode ROISfixXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.ROISfixXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> ROISfixXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.ROISfixXMLAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode RuoniaXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.RuoniaXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> RuoniaXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.RuoniaXMLAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode OstatDepoXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.OstatDepoXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> OstatDepoXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.OstatDepoXMLAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode ValIntDayXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.ValIntDayXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> ValIntDayXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.ValIntDayXMLAsync(fromDate, ToDate);
		}

		public System.Data.DataSet ValIntDay(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.ValIntDay(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> ValIntDayAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.ValIntDayAsync(fromDate, ToDate);
		}

		public System.Data.DataSet OstatDepo(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.OstatDepo(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> OstatDepoAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.OstatDepoAsync(fromDate, ToDate);
		}

		public System.Data.DataSet ROISfix(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.ROISfix(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> ROISfixAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.ROISfixAsync(fromDate, ToDate);
		}

		public System.Data.DataSet Ruonia(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.Ruonia(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> RuoniaAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.RuoniaAsync(fromDate, ToDate);
		}

		public System.Data.DataSet mrrf7D(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.mrrf7D(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> mrrf7DAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.mrrf7DAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode mrrf7DXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.mrrf7DXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> mrrf7DXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.mrrf7DXMLAsync(fromDate, ToDate);
		}

		public System.Data.DataSet RepoDebtUSD(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.RepoDebtUSD(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> RepoDebtUSDAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.RepoDebtUSDAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode RepoDebtUSDXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.RepoDebtUSDXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> RepoDebtUSDXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.RepoDebtUSDXMLAsync(fromDate, ToDate);
		}

		public System.Data.DataSet mrrf(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.mrrf(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> mrrfAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.mrrfAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode mrrfXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.mrrfXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> mrrfXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.mrrfXMLAsync(fromDate, ToDate);
		}

		public System.Data.DataSet Saldo(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.Saldo(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> SaldoAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SaldoAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode NewsInfoXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.NewsInfoXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> NewsInfoXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.NewsInfoXMLAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode OmodInfoXML()
		{
			return base.Channel.OmodInfoXML();
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> OmodInfoXMLAsync()
		{
			return base.Channel.OmodInfoXMLAsync();
		}

		public System.Data.DataSet XVol(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.XVol(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> XVolAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.XVolAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode XVolXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.XVolXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> XVolXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.XVolXMLAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode MainInfoXML()
		{
			return base.Channel.MainInfoXML();
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> MainInfoXMLAsync()
		{
			return base.Channel.MainInfoXMLAsync();
		}

		public System.Xml.XmlNode AllDataInfoXML()
		{
			return base.Channel.AllDataInfoXML();
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> AllDataInfoXMLAsync()
		{
			return base.Channel.AllDataInfoXMLAsync();
		}

		public System.Data.DataSet NewsInfo(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.NewsInfo(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> NewsInfoAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.NewsInfoAsync(fromDate, ToDate);
		}

		public System.Data.DataSet SwapDayTotal(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapDayTotal(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> SwapDayTotalAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapDayTotalAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode SwapDayTotalXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapDayTotalXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> SwapDayTotalXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapDayTotalXMLAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode SwapDynamicXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapDynamicXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> SwapDynamicXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapDynamicXMLAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode SwapInfoSellUSDVolXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapInfoSellUSDVolXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> SwapInfoSellUSDVolXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapInfoSellUSDVolXMLAsync(fromDate, ToDate);
		}

		public System.Data.DataSet SwapInfoSellUSDVol(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapInfoSellUSDVol(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> SwapInfoSellUSDVolAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapInfoSellUSDVolAsync(fromDate, ToDate);
		}

		public System.Data.DataSet SwapInfoSellUSD(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapInfoSellUSD(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> SwapInfoSellUSDAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapInfoSellUSDAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode SwapInfoSellUSDXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapInfoSellUSDXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> SwapInfoSellUSDXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapInfoSellUSDXMLAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode BiCurBaseXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.BiCurBaseXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> BiCurBaseXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.BiCurBaseXMLAsync(fromDate, ToDate);
		}

		public System.Data.DataSet BiCurBase(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.BiCurBase(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> BiCurBaseAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.BiCurBaseAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode BiCurBacketXML()
		{
			return base.Channel.BiCurBacketXML();
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> BiCurBacketXMLAsync()
		{
			return base.Channel.BiCurBacketXMLAsync();
		}

		public System.Data.DataSet BiCurBacket()
		{
			return base.Channel.BiCurBacket();
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> BiCurBacketAsync()
		{
			return base.Channel.BiCurBacketAsync();
		}

		public System.Data.DataSet SwapDynamic(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapDynamic(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> SwapDynamicAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapDynamicAsync(fromDate, ToDate);
		}

		public System.Data.DataSet SwapMonthTotal(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapMonthTotal(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> SwapMonthTotalAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapMonthTotalAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode SwapMonthTotalXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapMonthTotalXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> SwapMonthTotalXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.SwapMonthTotalXMLAsync(fromDate, ToDate);
		}

		public System.Data.DataSet MKR(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.MKR(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> MKRAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.MKRAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode MKRXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.MKRXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> MKRXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.MKRXMLAsync(fromDate, ToDate);
		}

		public System.Data.DataSet DV(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.DV(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> DVAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.DVAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode DVXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.DVXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> DVXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.DVXMLAsync(fromDate, ToDate);
		}

		public System.Data.DataSet Repo_debt(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.Repo_debt(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> Repo_debtAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.Repo_debtAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode Repo_debtXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.Repo_debtXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> Repo_debtXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.Repo_debtXMLAsync(fromDate, ToDate);
		}

		public System.Data.DataSet Coins_base(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.Coins_base(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> Coins_baseAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.Coins_baseAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode Coins_baseXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.Coins_baseXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> Coins_baseXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.Coins_baseXMLAsync(fromDate, ToDate);
		}

		public System.Data.DataSet FixingBase(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.FixingBase(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> FixingBaseAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.FixingBaseAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode FixingBaseXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.FixingBaseXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> FixingBaseXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.FixingBaseXMLAsync(fromDate, ToDate);
		}

		public System.Data.DataSet Overnight(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.Overnight(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> OvernightAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.OvernightAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode OvernightXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.OvernightXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> OvernightXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.OvernightXMLAsync(fromDate, ToDate);
		}

		public System.Data.DataSet Bauction(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.Bauction(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> BauctionAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.BauctionAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode BauctionXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.BauctionXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> BauctionXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.BauctionXMLAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode DepoDynamicXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.DepoDynamicXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> DepoDynamicXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.DepoDynamicXMLAsync(fromDate, ToDate);
		}

		public System.Data.DataSet DepoDynamic(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.DepoDynamic(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> DepoDynamicAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.DepoDynamicAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode OstatDynamicXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.OstatDynamicXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> OstatDynamicXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.OstatDynamicXMLAsync(fromDate, ToDate);
		}

		public System.Data.DataSet OstatDynamic(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.OstatDynamic(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> OstatDynamicAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.OstatDynamicAsync(fromDate, ToDate);
		}

		public System.Xml.XmlNode DragMetDynamicXML(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.DragMetDynamicXML(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> DragMetDynamicXMLAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.DragMetDynamicXMLAsync(fromDate, ToDate);
		}

		public System.Data.DataSet DragMetDynamic(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.DragMetDynamic(fromDate, ToDate);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> DragMetDynamicAsync(System.DateTime fromDate, System.DateTime ToDate)
		{
			return base.Channel.DragMetDynamicAsync(fromDate, ToDate);
		}

		public System.DateTime GetLatestDateTime()
		{
			return base.Channel.GetLatestDateTime();
		}

		public System.Threading.Tasks.Task<System.DateTime> GetLatestDateTimeAsync()
		{
			return base.Channel.GetLatestDateTimeAsync();
		}

		public string GetLatestDate()
		{
			return base.Channel.GetLatestDate();
		}

		public System.Threading.Tasks.Task<string> GetLatestDateAsync()
		{
			return base.Channel.GetLatestDateAsync();
		}

		public System.DateTime GetLatestDateTimeSeld()
		{
			return base.Channel.GetLatestDateTimeSeld();
		}

		public System.Threading.Tasks.Task<System.DateTime> GetLatestDateTimeSeldAsync()
		{
			return base.Channel.GetLatestDateTimeSeldAsync();
		}

		public string GetLatestDateSeld()
		{
			return base.Channel.GetLatestDateSeld();
		}

		public System.Threading.Tasks.Task<string> GetLatestDateSeldAsync()
		{
			return base.Channel.GetLatestDateSeldAsync();
		}

		public System.Xml.XmlNode EnumValutesXML(bool Seld)
		{
			return base.Channel.EnumValutesXML(Seld);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> EnumValutesXMLAsync(bool Seld)
		{
			return base.Channel.EnumValutesXMLAsync(Seld);
		}

		public System.Data.DataSet EnumValutes(bool Seld)
		{
			return base.Channel.EnumValutes(Seld);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> EnumValutesAsync(bool Seld)
		{
			return base.Channel.EnumValutesAsync(Seld);
		}

		public System.DateTime GetLatestReutersDateTime()
		{
			return base.Channel.GetLatestReutersDateTime();
		}

		public System.Threading.Tasks.Task<System.DateTime> GetLatestReutersDateTimeAsync()
		{
			return base.Channel.GetLatestReutersDateTimeAsync();
		}

		public System.Xml.XmlNode EnumReutersValutesXML()
		{
			return base.Channel.EnumReutersValutesXML();
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> EnumReutersValutesXMLAsync()
		{
			return base.Channel.EnumReutersValutesXMLAsync();
		}

		public System.Data.DataSet EnumReutersValutes()
		{
			return base.Channel.EnumReutersValutes();
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> EnumReutersValutesAsync()
		{
			return base.Channel.EnumReutersValutesAsync();
		}

		public System.Xml.XmlNode GetReutersCursOnDateXML(System.DateTime On_date)
		{
			return base.Channel.GetReutersCursOnDateXML(On_date);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> GetReutersCursOnDateXMLAsync(System.DateTime On_date)
		{
			return base.Channel.GetReutersCursOnDateXMLAsync(On_date);
		}

		public System.Data.DataSet GetReutersCursOnDate(System.DateTime On_date)
		{
			return base.Channel.GetReutersCursOnDate(On_date);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> GetReutersCursOnDateAsync(System.DateTime On_date)
		{
			return base.Channel.GetReutersCursOnDateAsync(On_date);
		}

		public System.Xml.XmlNode GetReutersCursDynamicXML(System.DateTime FromDate, System.DateTime ToDate, int NumCode)
		{
			return base.Channel.GetReutersCursDynamicXML(FromDate, ToDate, NumCode);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> GetReutersCursDynamicXMLAsync(System.DateTime FromDate, System.DateTime ToDate, int NumCode)
		{
			return base.Channel.GetReutersCursDynamicXMLAsync(FromDate, ToDate, NumCode);
		}

		public System.Data.DataSet GetReutersCursDynamic(System.DateTime FromDate, System.DateTime ToDate, int NumCode)
		{
			return base.Channel.GetReutersCursDynamic(FromDate, ToDate, NumCode);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> GetReutersCursDynamicAsync(System.DateTime FromDate, System.DateTime ToDate, int NumCode)
		{
			return base.Channel.GetReutersCursDynamicAsync(FromDate, ToDate, NumCode);
		}

		public System.Xml.XmlNode GetCursDynamicXML(System.DateTime FromDate, System.DateTime ToDate, string ValutaCode)
		{
			return base.Channel.GetCursDynamicXML(FromDate, ToDate, ValutaCode);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> GetCursDynamicXMLAsync(System.DateTime FromDate, System.DateTime ToDate, string ValutaCode)
		{
			return base.Channel.GetCursDynamicXMLAsync(FromDate, ToDate, ValutaCode);
		}

		public System.Data.DataSet GetCursDynamic(System.DateTime FromDate, System.DateTime ToDate, string ValutaCode)
		{
			return base.Channel.GetCursDynamic(FromDate, ToDate, ValutaCode);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> GetCursDynamicAsync(System.DateTime FromDate, System.DateTime ToDate, string ValutaCode)
		{
			return base.Channel.GetCursDynamicAsync(FromDate, ToDate, ValutaCode);
		}

		public System.Xml.XmlNode GetCursOnDateXML(System.DateTime On_date)
		{
			return base.Channel.GetCursOnDateXML(On_date);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> GetCursOnDateXMLAsync(System.DateTime On_date)
		{
			return base.Channel.GetCursOnDateXMLAsync(On_date);
		}

		public System.Xml.XmlNode GetSeldCursOnDateXML(System.DateTime On_date)
		{
			return base.Channel.GetSeldCursOnDateXML(On_date);
		}

		public System.Threading.Tasks.Task<System.Xml.XmlNode> GetSeldCursOnDateXMLAsync(System.DateTime On_date)
		{
			return base.Channel.GetSeldCursOnDateXMLAsync(On_date);
		}

		public System.Data.DataSet GetSeldCursOnDate(System.DateTime On_date)
		{
			return base.Channel.GetSeldCursOnDate(On_date);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> GetSeldCursOnDateAsync(System.DateTime On_date)
		{
			return base.Channel.GetSeldCursOnDateAsync(On_date);
		}

		public System.Data.DataSet GetCursOnDate(System.DateTime On_date)
		{
			return base.Channel.GetCursOnDate(On_date);
		}

		public System.Threading.Tasks.Task<System.Data.DataSet> GetCursOnDateAsync(System.DateTime On_date)
		{
			return base.Channel.GetCursOnDateAsync(On_date);
		}
	}
}
