// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System.Text.Json.Serialization;

namespace ForaFinServices.Models;

public class UsGaap
{
    [JsonPropertyName("AccountsAndOtherReceivablesNetCurrent")]
    public AccountsAndOtherReceivablesNetCurrent AccountsAndOtherReceivablesNetCurrent { get; set; }

    [JsonPropertyName("AccountsPayableCurrent")]
    public AccountsPayableCurrent AccountsPayableCurrent { get; set; }

    [JsonPropertyName("AccountsReceivableGross")]
    public AccountsReceivableGross AccountsReceivableGross { get; set; }

    [JsonPropertyName("AccountsReceivableGrossCurrent")]
    public AccountsReceivableGrossCurrent AccountsReceivableGrossCurrent { get; set; }

    [JsonPropertyName("AccountsReceivableNet")]
    public AccountsReceivableNet AccountsReceivableNet { get; set; }

    [JsonPropertyName("AccountsReceivableNetCurrent")]
    public AccountsReceivableNetCurrent AccountsReceivableNetCurrent { get; set; }

    [JsonPropertyName("AccrualForTaxesOtherThanIncomeTaxesCurrent")]
    public AccrualForTaxesOtherThanIncomeTaxesCurrent AccrualForTaxesOtherThanIncomeTaxesCurrent { get; set; }

    [JsonPropertyName("AccruedRentCurrent")]
    public AccruedRentCurrent AccruedRentCurrent { get; set; }

    [JsonPropertyName("AccumulatedDepreciationDepletionAndAmortizationPropertyPlantAndEquipment")]
    public AccumulatedDepreciationDepletionAndAmortizationPropertyPlantAndEquipment AccumulatedDepreciationDepletionAndAmortizationPropertyPlantAndEquipment { get; set; }

    [JsonPropertyName("AccumulatedOtherComprehensiveIncomeLossDefinedBenefitPensionAndOtherPostretirementPlansNetOfTax")]
    public AccumulatedOtherComprehensiveIncomeLossDefinedBenefitPensionAndOtherPostretirementPlansNetOfTax AccumulatedOtherComprehensiveIncomeLossDefinedBenefitPensionAndOtherPostretirementPlansNetOfTax { get; set; }

    [JsonPropertyName("AccumulatedOtherComprehensiveIncomeLossNetOfTax")]
    public AccumulatedOtherComprehensiveIncomeLossNetOfTax AccumulatedOtherComprehensiveIncomeLossNetOfTax { get; set; }

    [JsonPropertyName("AdditionalPaidInCapital")]
    public AdditionalPaidInCapital AdditionalPaidInCapital { get; set; }

    [JsonPropertyName("AdjustmentsRelatedToTaxWithholdingForShareBasedCompensation")]
    public AdjustmentsRelatedToTaxWithholdingForShareBasedCompensation AdjustmentsRelatedToTaxWithholdingForShareBasedCompensation { get; set; }

    [JsonPropertyName("AdjustmentsToAdditionalPaidInCapitalSharebasedCompensationRequisiteServicePeriodRecognitionValue")]
    public AdjustmentsToAdditionalPaidInCapitalSharebasedCompensationRequisiteServicePeriodRecognitionValue AdjustmentsToAdditionalPaidInCapitalSharebasedCompensationRequisiteServicePeriodRecognitionValue { get; set; }

    [JsonPropertyName("AdjustmentsToAdditionalPaidInCapitalTaxEffectFromShareBasedCompensation")]
    public AdjustmentsToAdditionalPaidInCapitalTaxEffectFromShareBasedCompensation AdjustmentsToAdditionalPaidInCapitalTaxEffectFromShareBasedCompensation { get; set; }

    [JsonPropertyName("AdvertisingExpense")]
    public AdvertisingExpense AdvertisingExpense { get; set; }

    [JsonPropertyName("AllocatedShareBasedCompensationExpense")]
    public AllocatedShareBasedCompensationExpense AllocatedShareBasedCompensationExpense { get; set; }

    [JsonPropertyName("AllowanceForDoubtfulAccountsReceivable")]
    public AllowanceForDoubtfulAccountsReceivable AllowanceForDoubtfulAccountsReceivable { get; set; }

    [JsonPropertyName("AllowanceForDoubtfulAccountsReceivableCurrent")]
    public AllowanceForDoubtfulAccountsReceivableCurrent AllowanceForDoubtfulAccountsReceivableCurrent { get; set; }

    [JsonPropertyName("AllowanceForDoubtfulAccountsReceivableWriteOffs")]
    public AllowanceForDoubtfulAccountsReceivableWriteOffs AllowanceForDoubtfulAccountsReceivableWriteOffs { get; set; }

    [JsonPropertyName("AmortizationOfDebtDiscountPremium")]
    public AmortizationOfDebtDiscountPremium AmortizationOfDebtDiscountPremium { get; set; }

    [JsonPropertyName("AmortizationOfFinancingCostsAndDiscounts")]
    public AmortizationOfFinancingCostsAndDiscounts AmortizationOfFinancingCostsAndDiscounts { get; set; }

    [JsonPropertyName("AmortizationOfIntangibleAssets")]
    public AmortizationOfIntangibleAssets AmortizationOfIntangibleAssets { get; set; }

    [JsonPropertyName("AntidilutiveSecuritiesExcludedFromComputationOfEarningsPerShareAmount")]
    public AntidilutiveSecuritiesExcludedFromComputationOfEarningsPerShareAmount AntidilutiveSecuritiesExcludedFromComputationOfEarningsPerShareAmount { get; set; }

    [JsonPropertyName("AssetRetirementObligation")]
    public AssetRetirementObligation AssetRetirementObligation { get; set; }

    [JsonPropertyName("AssetRetirementObligationAccretionExpense")]
    public AssetRetirementObligationAccretionExpense AssetRetirementObligationAccretionExpense { get; set; }

    [JsonPropertyName("AssetRetirementObligationLiabilitiesIncurred")]
    public AssetRetirementObligationLiabilitiesIncurred AssetRetirementObligationLiabilitiesIncurred { get; set; }

    [JsonPropertyName("AssetRetirementObligationLiabilitiesSettled")]
    public AssetRetirementObligationLiabilitiesSettled AssetRetirementObligationLiabilitiesSettled { get; set; }

    [JsonPropertyName("AssetRetirementObligationRevisionOfEstimate")]
    public AssetRetirementObligationRevisionOfEstimate AssetRetirementObligationRevisionOfEstimate { get; set; }

    [JsonPropertyName("Assets")]
    public Assets Assets { get; set; }

    [JsonPropertyName("AssetsCurrent")]
    public AssetsCurrent AssetsCurrent { get; set; }

    [JsonPropertyName("AssetsHeldForSaleCurrent")]
    public AssetsHeldForSaleCurrent AssetsHeldForSaleCurrent { get; set; }

    [JsonPropertyName("AssetsHeldForSaleNotPartOfDisposalGroup")]
    public AssetsHeldForSaleNotPartOfDisposalGroup AssetsHeldForSaleNotPartOfDisposalGroup { get; set; }

    [JsonPropertyName("AssetsHeldForSaleNotPartOfDisposalGroupCurrent")]
    public AssetsHeldForSaleNotPartOfDisposalGroupCurrent AssetsHeldForSaleNotPartOfDisposalGroupCurrent { get; set; }

    [JsonPropertyName("AssetsNoncurrent")]
    public AssetsNoncurrent AssetsNoncurrent { get; set; }

    [JsonPropertyName("AssetsOfDisposalGroupIncludingDiscontinuedOperationCurrent")]
    public AssetsOfDisposalGroupIncludingDiscontinuedOperationCurrent AssetsOfDisposalGroupIncludingDiscontinuedOperationCurrent { get; set; }

    [JsonPropertyName("BankOverdrafts")]
    public BankOverdrafts BankOverdrafts { get; set; }

    [JsonPropertyName("BridgeLoan")]
    public BridgeLoan BridgeLoan { get; set; }

    [JsonPropertyName("BusinessAcquisitionCostOfAcquiredEntityTransactionCosts")]
    public BusinessAcquisitionCostOfAcquiredEntityTransactionCosts BusinessAcquisitionCostOfAcquiredEntityTransactionCosts { get; set; }

    [JsonPropertyName("BusinessAcquisitionEquityInterestIssuedOrIssuableValueAssigned")]
    public BusinessAcquisitionEquityInterestIssuedOrIssuableValueAssigned BusinessAcquisitionEquityInterestIssuedOrIssuableValueAssigned { get; set; }

    [JsonPropertyName("BusinessAcquisitionPreacquisitionContingencyAmount")]
    public BusinessAcquisitionPreacquisitionContingencyAmount BusinessAcquisitionPreacquisitionContingencyAmount { get; set; }

    [JsonPropertyName("BusinessAcquisitionProFormaEarningsPerShareBasic")]
    public BusinessAcquisitionProFormaEarningsPerShareBasic BusinessAcquisitionProFormaEarningsPerShareBasic { get; set; }

    [JsonPropertyName("BusinessAcquisitionProFormaEarningsPerShareDiluted")]
    public BusinessAcquisitionProFormaEarningsPerShareDiluted BusinessAcquisitionProFormaEarningsPerShareDiluted { get; set; }

    [JsonPropertyName("BusinessAcquisitionProFormaIncomeLossFromContinuingOperationsBeforeChangesInAccountingAndExtraordinaryItemsNetOfTax")]
    public BusinessAcquisitionProFormaIncomeLossFromContinuingOperationsBeforeChangesInAccountingAndExtraordinaryItemsNetOfTax BusinessAcquisitionProFormaIncomeLossFromContinuingOperationsBeforeChangesInAccountingAndExtraordinaryItemsNetOfTax { get; set; }

    [JsonPropertyName("BusinessAcquisitionProFormaNetIncomeLoss")]
    public BusinessAcquisitionProFormaNetIncomeLoss BusinessAcquisitionProFormaNetIncomeLoss { get; set; }

    [JsonPropertyName("BusinessAcquisitionProFormaRevenue")]
    public BusinessAcquisitionProFormaRevenue BusinessAcquisitionProFormaRevenue { get; set; }

    [JsonPropertyName("BusinessAcquisitionPurchasePriceAllocationAssetsAcquiredLiabilitiesAssumedNet")]
    public BusinessAcquisitionPurchasePriceAllocationAssetsAcquiredLiabilitiesAssumedNet BusinessAcquisitionPurchasePriceAllocationAssetsAcquiredLiabilitiesAssumedNet { get; set; }

    [JsonPropertyName("BusinessAcquisitionPurchasePriceAllocationGoodwillAmount")]
    public BusinessAcquisitionPurchasePriceAllocationGoodwillAmount BusinessAcquisitionPurchasePriceAllocationGoodwillAmount { get; set; }

    [JsonPropertyName("BusinessAcquisitionPurchasePriceAllocationPropertyPlantAndEquipment")]
    public BusinessAcquisitionPurchasePriceAllocationPropertyPlantAndEquipment BusinessAcquisitionPurchasePriceAllocationPropertyPlantAndEquipment { get; set; }

    [JsonPropertyName("BusinessAcquisitionsProFormaNetIncomeLoss")]
    public BusinessAcquisitionsProFormaNetIncomeLoss BusinessAcquisitionsProFormaNetIncomeLoss { get; set; }

    [JsonPropertyName("BusinessAcquisitionsProFormaRevenue")]
    public BusinessAcquisitionsProFormaRevenue BusinessAcquisitionsProFormaRevenue { get; set; }

    [JsonPropertyName("BusinessCombinationAcquiredReceivablesEstimatedUncollectible")]
    public BusinessCombinationAcquiredReceivablesEstimatedUncollectible BusinessCombinationAcquiredReceivablesEstimatedUncollectible { get; set; }

    [JsonPropertyName("BusinessCombinationAcquiredReceivablesFairValue")]
    public BusinessCombinationAcquiredReceivablesFairValue BusinessCombinationAcquiredReceivablesFairValue { get; set; }

    [JsonPropertyName("BusinessCombinationAcquiredReceivablesGrossContractualAmount")]
    public BusinessCombinationAcquiredReceivablesGrossContractualAmount BusinessCombinationAcquiredReceivablesGrossContractualAmount { get; set; }

    [JsonPropertyName("BusinessCombinationAcquisitionRelatedCosts")]
    public BusinessCombinationAcquisitionRelatedCosts BusinessCombinationAcquisitionRelatedCosts { get; set; }

    [JsonPropertyName("BusinessCombinationProFormaInformationRevenueOfAcquireeSinceAcquisitionDateActual")]
    public BusinessCombinationProFormaInformationRevenueOfAcquireeSinceAcquisitionDateActual BusinessCombinationProFormaInformationRevenueOfAcquireeSinceAcquisitionDateActual { get; set; }

    [JsonPropertyName("CapitalExpendituresIncurredButNotYetPaid")]
    public CapitalExpendituresIncurredButNotYetPaid CapitalExpendituresIncurredButNotYetPaid { get; set; }

    [JsonPropertyName("CapitalizedContractCostNet")]
    public CapitalizedContractCostNet CapitalizedContractCostNet { get; set; }

    [JsonPropertyName("CapitalizedContractCostNetCurrent")]
    public CapitalizedContractCostNetCurrent CapitalizedContractCostNetCurrent { get; set; }

    [JsonPropertyName("CapitalLeasedAssetsGross")]
    public CapitalLeasedAssetsGross CapitalLeasedAssetsGross { get; set; }

    [JsonPropertyName("CapitalLeaseObligations")]
    public CapitalLeaseObligations CapitalLeaseObligations { get; set; }

    [JsonPropertyName("CapitalLeaseObligationsCurrent")]
    public CapitalLeaseObligationsCurrent CapitalLeaseObligationsCurrent { get; set; }

    [JsonPropertyName("CapitalLeaseObligationsNoncurrent")]
    public CapitalLeaseObligationsNoncurrent CapitalLeaseObligationsNoncurrent { get; set; }

    [JsonPropertyName("CapitalLeasesFutureMinimumPaymentsDue")]
    public CapitalLeasesFutureMinimumPaymentsDue CapitalLeasesFutureMinimumPaymentsDue { get; set; }

    [JsonPropertyName("CapitalLeasesFutureMinimumPaymentsDueCurrent")]
    public CapitalLeasesFutureMinimumPaymentsDueCurrent CapitalLeasesFutureMinimumPaymentsDueCurrent { get; set; }

    [JsonPropertyName("CapitalLeasesFutureMinimumPaymentsDueInFiveYears")]
    public CapitalLeasesFutureMinimumPaymentsDueInFiveYears CapitalLeasesFutureMinimumPaymentsDueInFiveYears { get; set; }

    [JsonPropertyName("CapitalLeasesFutureMinimumPaymentsDueInFourYears")]
    public CapitalLeasesFutureMinimumPaymentsDueInFourYears CapitalLeasesFutureMinimumPaymentsDueInFourYears { get; set; }

    [JsonPropertyName("CapitalLeasesFutureMinimumPaymentsDueInThreeYears")]
    public CapitalLeasesFutureMinimumPaymentsDueInThreeYears CapitalLeasesFutureMinimumPaymentsDueInThreeYears { get; set; }

    [JsonPropertyName("CapitalLeasesFutureMinimumPaymentsDueInTwoYears")]
    public CapitalLeasesFutureMinimumPaymentsDueInTwoYears CapitalLeasesFutureMinimumPaymentsDueInTwoYears { get; set; }

    [JsonPropertyName("CapitalLeasesFutureMinimumPaymentsDueThereafter")]
    public CapitalLeasesFutureMinimumPaymentsDueThereafter CapitalLeasesFutureMinimumPaymentsDueThereafter { get; set; }

    [JsonPropertyName("CapitalLeasesFutureMinimumPaymentsPresentValueOfNetMinimumPayments")]
    public CapitalLeasesFutureMinimumPaymentsPresentValueOfNetMinimumPayments CapitalLeasesFutureMinimumPaymentsPresentValueOfNetMinimumPayments { get; set; }

    [JsonPropertyName("CapitalLeasesIncomeStatementAmortizationExpense")]
    public CapitalLeasesIncomeStatementAmortizationExpense CapitalLeasesIncomeStatementAmortizationExpense { get; set; }

    [JsonPropertyName("CapitalLeasesLesseeBalanceSheetAssetsByMajorClassAccumulatedDeprecation")]
    public CapitalLeasesLesseeBalanceSheetAssetsByMajorClassAccumulatedDeprecation CapitalLeasesLesseeBalanceSheetAssetsByMajorClassAccumulatedDeprecation { get; set; }

    [JsonPropertyName("CashAcquiredFromAcquisition")]
    public CashAcquiredFromAcquisition CashAcquiredFromAcquisition { get; set; }

    [JsonPropertyName("CashAndCashEquivalentsAtCarryingValue")]
    public CashAndCashEquivalentsAtCarryingValue CashAndCashEquivalentsAtCarryingValue { get; set; }

    [JsonPropertyName("CashAndCashEquivalentsPeriodIncreaseDecrease")]
    public CashAndCashEquivalentsPeriodIncreaseDecrease CashAndCashEquivalentsPeriodIncreaseDecrease { get; set; }

    [JsonPropertyName("CashCashEquivalentsRestrictedCashAndRestrictedCashEquivalents")]
    public CashCashEquivalentsRestrictedCashAndRestrictedCashEquivalents CashCashEquivalentsRestrictedCashAndRestrictedCashEquivalents { get; set; }

    [JsonPropertyName("CashCashEquivalentsRestrictedCashAndRestrictedCashEquivalentsIncludingDisposalGroupAndDiscontinuedOperations")]
    public CashCashEquivalentsRestrictedCashAndRestrictedCashEquivalentsIncludingDisposalGroupAndDiscontinuedOperations CashCashEquivalentsRestrictedCashAndRestrictedCashEquivalentsIncludingDisposalGroupAndDiscontinuedOperations { get; set; }

    [JsonPropertyName("CashCashEquivalentsRestrictedCashAndRestrictedCashEquivalentsPeriodIncreaseDecreaseIncludingExchangeRateEffect")]
    public CashCashEquivalentsRestrictedCashAndRestrictedCashEquivalentsPeriodIncreaseDecreaseIncludingExchangeRateEffect CashCashEquivalentsRestrictedCashAndRestrictedCashEquivalentsPeriodIncreaseDecreaseIncludingExchangeRateEffect { get; set; }

    [JsonPropertyName("CashPaidForCapitalizedInterest")]
    public CashPaidForCapitalizedInterest CashPaidForCapitalizedInterest { get; set; }

    [JsonPropertyName("CashSurrenderValueOfLifeInsurance")]
    public CashSurrenderValueOfLifeInsurance CashSurrenderValueOfLifeInsurance { get; set; }

    [JsonPropertyName("CommonStockCapitalSharesReservedForFutureIssuance")]
    public CommonStockCapitalSharesReservedForFutureIssuance CommonStockCapitalSharesReservedForFutureIssuance { get; set; }

    [JsonPropertyName("CommonStockDividendsPerShareCashPaid")]
    public CommonStockDividendsPerShareCashPaid CommonStockDividendsPerShareCashPaid { get; set; }

    [JsonPropertyName("CommonStockDividendsPerShareDeclared")]
    public CommonStockDividendsPerShareDeclared CommonStockDividendsPerShareDeclared { get; set; }

    [JsonPropertyName("CommonStockParOrStatedValuePerShare")]
    public CommonStockParOrStatedValuePerShare CommonStockParOrStatedValuePerShare { get; set; }

    [JsonPropertyName("CommonStockSharesAuthorized")]
    public CommonStockSharesAuthorized CommonStockSharesAuthorized { get; set; }

    [JsonPropertyName("CommonStockSharesIssued")]
    public CommonStockSharesIssued CommonStockSharesIssued { get; set; }

    [JsonPropertyName("CommonStockSharesOutstanding")]
    public CommonStockSharesOutstanding CommonStockSharesOutstanding { get; set; }

    [JsonPropertyName("CommonStockValue")]
    public CommonStockValue CommonStockValue { get; set; }

    [JsonPropertyName("ComprehensiveIncomeNetOfTax")]
    public ComprehensiveIncomeNetOfTax ComprehensiveIncomeNetOfTax { get; set; }

    [JsonPropertyName("ComprehensiveIncomeNetOfTaxAttributableToNoncontrollingInterest")]
    public ComprehensiveIncomeNetOfTaxAttributableToNoncontrollingInterest ComprehensiveIncomeNetOfTaxAttributableToNoncontrollingInterest { get; set; }

    [JsonPropertyName("ComprehensiveIncomeNetOfTaxIncludingPortionAttributableToNoncontrollingInterest")]
    public ComprehensiveIncomeNetOfTaxIncludingPortionAttributableToNoncontrollingInterest ComprehensiveIncomeNetOfTaxIncludingPortionAttributableToNoncontrollingInterest { get; set; }

    [JsonPropertyName("ConstructionInProgressGross")]
    public ConstructionInProgressGross ConstructionInProgressGross { get; set; }

    [JsonPropertyName("ContractWithCustomerAssetNet")]
    public ContractWithCustomerAssetNet ContractWithCustomerAssetNet { get; set; }

    [JsonPropertyName("ContractWithCustomerAssetNetCurrent")]
    public ContractWithCustomerAssetNetCurrent ContractWithCustomerAssetNetCurrent { get; set; }

    [JsonPropertyName("ContractWithCustomerLiability")]
    public ContractWithCustomerLiability ContractWithCustomerLiability { get; set; }

    [JsonPropertyName("ContractWithCustomerLiabilityCurrent")]
    public ContractWithCustomerLiabilityCurrent ContractWithCustomerLiabilityCurrent { get; set; }

    [JsonPropertyName("ContractWithCustomerLiabilityNoncurrent")]
    public ContractWithCustomerLiabilityNoncurrent ContractWithCustomerLiabilityNoncurrent { get; set; }

    [JsonPropertyName("ContractWithCustomerLiabilityRevenueRecognized")]
    public ContractWithCustomerLiabilityRevenueRecognized ContractWithCustomerLiabilityRevenueRecognized { get; set; }

    [JsonPropertyName("ContractWithCustomerPerformanceObligationSatisfiedInPreviousPeriod")]
    public ContractWithCustomerPerformanceObligationSatisfiedInPreviousPeriod ContractWithCustomerPerformanceObligationSatisfiedInPreviousPeriod { get; set; }

    [JsonPropertyName("ContractWithCustomerReceivableAllowanceForCreditLoss")]
    public ContractWithCustomerReceivableAllowanceForCreditLoss ContractWithCustomerReceivableAllowanceForCreditLoss { get; set; }

    [JsonPropertyName("CostOfGoodsAndServicesSold")]
    public CostOfGoodsAndServicesSold CostOfGoodsAndServicesSold { get; set; }

    [JsonPropertyName("CostsAndExpenses")]
    public CostsAndExpenses CostsAndExpenses { get; set; }

    [JsonPropertyName("CumulativeEffectOfNewAccountingPrincipleInPeriodOfAdoption")]
    public CumulativeEffectOfNewAccountingPrincipleInPeriodOfAdoption CumulativeEffectOfNewAccountingPrincipleInPeriodOfAdoption { get; set; }

    [JsonPropertyName("CurrentFederalTaxExpenseBenefit")]
    public CurrentFederalTaxExpenseBenefit CurrentFederalTaxExpenseBenefit { get; set; }

    [JsonPropertyName("CurrentForeignTaxExpenseBenefit")]
    public CurrentForeignTaxExpenseBenefit CurrentForeignTaxExpenseBenefit { get; set; }

    [JsonPropertyName("CurrentStateAndLocalTaxExpenseBenefit")]
    public CurrentStateAndLocalTaxExpenseBenefit CurrentStateAndLocalTaxExpenseBenefit { get; set; }

    [JsonPropertyName("CustomerAdvancesAndDepositsCurrent")]
    public CustomerAdvancesAndDepositsCurrent CustomerAdvancesAndDepositsCurrent { get; set; }

    [JsonPropertyName("DebtAndCapitalLeaseObligations")]
    public DebtAndCapitalLeaseObligations DebtAndCapitalLeaseObligations { get; set; }

    [JsonPropertyName("DebtInstrumentCarryingAmount")]
    public DebtInstrumentCarryingAmount DebtInstrumentCarryingAmount { get; set; }

    [JsonPropertyName("DebtInstrumentUnamortizedDiscountPremiumNet")]
    public DebtInstrumentUnamortizedDiscountPremiumNet DebtInstrumentUnamortizedDiscountPremiumNet { get; set; }

    [JsonPropertyName("DeferredCostsCurrent")]
    public DeferredCostsCurrent DeferredCostsCurrent { get; set; }

    [JsonPropertyName("DeferredCreditsAndOtherLiabilitiesNoncurrent")]
    public DeferredCreditsAndOtherLiabilitiesNoncurrent DeferredCreditsAndOtherLiabilitiesNoncurrent { get; set; }

    [JsonPropertyName("DeferredFederalIncomeTaxExpenseBenefit")]
    public DeferredFederalIncomeTaxExpenseBenefit DeferredFederalIncomeTaxExpenseBenefit { get; set; }

    [JsonPropertyName("DeferredFinanceCostsNet")]
    public DeferredFinanceCostsNet DeferredFinanceCostsNet { get; set; }

    [JsonPropertyName("DeferredForeignIncomeTaxExpenseBenefit")]
    public DeferredForeignIncomeTaxExpenseBenefit DeferredForeignIncomeTaxExpenseBenefit { get; set; }

    [JsonPropertyName("DeferredIncomeTaxAssetsNet")]
    public DeferredIncomeTaxAssetsNet DeferredIncomeTaxAssetsNet { get; set; }

    [JsonPropertyName("DeferredIncomeTaxExpenseBenefit")]
    public DeferredIncomeTaxExpenseBenefit DeferredIncomeTaxExpenseBenefit { get; set; }

    [JsonPropertyName("DeferredIncomeTaxLiabilities")]
    public DeferredIncomeTaxLiabilities DeferredIncomeTaxLiabilities { get; set; }

    [JsonPropertyName("DeferredIncomeTaxLiabilitiesNet")]
    public DeferredIncomeTaxLiabilitiesNet DeferredIncomeTaxLiabilitiesNet { get; set; }

    [JsonPropertyName("DeferredRevenueAndCreditsCurrent")]
    public DeferredRevenueAndCreditsCurrent DeferredRevenueAndCreditsCurrent { get; set; }

    [JsonPropertyName("DeferredRevenueAndCreditsNoncurrent")]
    public DeferredRevenueAndCreditsNoncurrent DeferredRevenueAndCreditsNoncurrent { get; set; }

    [JsonPropertyName("DeferredRevenueNoncurrent")]
    public DeferredRevenueNoncurrent DeferredRevenueNoncurrent { get; set; }

    [JsonPropertyName("DeferredSalesCommission")]
    public DeferredSalesCommission DeferredSalesCommission { get; set; }

    [JsonPropertyName("DeferredStateAndLocalIncomeTaxExpenseBenefit")]
    public DeferredStateAndLocalIncomeTaxExpenseBenefit DeferredStateAndLocalIncomeTaxExpenseBenefit { get; set; }

    [JsonPropertyName("DeferredTaxAssetsGross")]
    public DeferredTaxAssetsGross DeferredTaxAssetsGross { get; set; }

    [JsonPropertyName("DeferredTaxAssetsLiabilitiesNet")]
    public DeferredTaxAssetsLiabilitiesNet DeferredTaxAssetsLiabilitiesNet { get; set; }

    [JsonPropertyName("DeferredTaxAssetsLiabilitiesNetCurrent")]
    public DeferredTaxAssetsLiabilitiesNetCurrent DeferredTaxAssetsLiabilitiesNetCurrent { get; set; }

    [JsonPropertyName("DeferredTaxAssetsLiabilitiesNetNoncurrent")]
    public DeferredTaxAssetsLiabilitiesNetNoncurrent DeferredTaxAssetsLiabilitiesNetNoncurrent { get; set; }

    [JsonPropertyName("DeferredTaxAssetsNet")]
    public DeferredTaxAssetsNet DeferredTaxAssetsNet { get; set; }

    [JsonPropertyName("DeferredTaxAssetsNetCurrent")]
    public DeferredTaxAssetsNetCurrent DeferredTaxAssetsNetCurrent { get; set; }

    [JsonPropertyName("DeferredTaxAssetsNetNoncurrent")]
    public DeferredTaxAssetsNetNoncurrent DeferredTaxAssetsNetNoncurrent { get; set; }

    [JsonPropertyName("DeferredTaxAssetsOperatingLossCarryforwards")]
    public DeferredTaxAssetsOperatingLossCarryforwards DeferredTaxAssetsOperatingLossCarryforwards { get; set; }

    [JsonPropertyName("DeferredTaxAssetsOperatingLossCarryforwardsStateAndLocal")]
    public DeferredTaxAssetsOperatingLossCarryforwardsStateAndLocal DeferredTaxAssetsOperatingLossCarryforwardsStateAndLocal { get; set; }

    [JsonPropertyName("DeferredTaxAssetsOther")]
    public DeferredTaxAssetsOther DeferredTaxAssetsOther { get; set; }

    [JsonPropertyName("DeferredTaxAssetsTaxDeferredExpenseCompensationAndBenefitsEmployeeBenefits")]
    public DeferredTaxAssetsTaxDeferredExpenseCompensationAndBenefitsEmployeeBenefits DeferredTaxAssetsTaxDeferredExpenseCompensationAndBenefitsEmployeeBenefits { get; set; }

    [JsonPropertyName("DeferredTaxAssetsTaxDeferredExpenseCompensationAndBenefitsOther")]
    public DeferredTaxAssetsTaxDeferredExpenseCompensationAndBenefitsOther DeferredTaxAssetsTaxDeferredExpenseCompensationAndBenefitsOther { get; set; }

    [JsonPropertyName("DeferredTaxAssetsTaxDeferredExpenseCompensationAndBenefitsPostretirementBenefits")]
    public DeferredTaxAssetsTaxDeferredExpenseCompensationAndBenefitsPostretirementBenefits DeferredTaxAssetsTaxDeferredExpenseCompensationAndBenefitsPostretirementBenefits { get; set; }

    [JsonPropertyName("DeferredTaxAssetsValuationAllowance")]
    public DeferredTaxAssetsValuationAllowance DeferredTaxAssetsValuationAllowance { get; set; }

    [JsonPropertyName("DeferredTaxLiabilities")]
    public DeferredTaxLiabilities DeferredTaxLiabilities { get; set; }

    [JsonPropertyName("DeferredTaxLiabilitiesGoodwillAndIntangibleAssets")]
    public DeferredTaxLiabilitiesGoodwillAndIntangibleAssets DeferredTaxLiabilitiesGoodwillAndIntangibleAssets { get; set; }

    [JsonPropertyName("DeferredTaxLiabilitiesGrossNoncurrent")]
    public DeferredTaxLiabilitiesGrossNoncurrent DeferredTaxLiabilitiesGrossNoncurrent { get; set; }

    [JsonPropertyName("DeferredTaxLiabilitiesNoncurrent")]
    public DeferredTaxLiabilitiesNoncurrent DeferredTaxLiabilitiesNoncurrent { get; set; }

    [JsonPropertyName("DeferredTaxLiabilitiesOther")]
    public DeferredTaxLiabilitiesOther DeferredTaxLiabilitiesOther { get; set; }

    [JsonPropertyName("DeferredTaxLiabilitiesPropertyPlantAndEquipment")]
    public DeferredTaxLiabilitiesPropertyPlantAndEquipment DeferredTaxLiabilitiesPropertyPlantAndEquipment { get; set; }

    [JsonPropertyName("DefinedBenefitPensionPlanLiabilitiesNoncurrent")]
    public DefinedBenefitPensionPlanLiabilitiesNoncurrent DefinedBenefitPensionPlanLiabilitiesNoncurrent { get; set; }

    [JsonPropertyName("DefinedBenefitPlanAccumulatedBenefitObligation")]
    public DefinedBenefitPlanAccumulatedBenefitObligation DefinedBenefitPlanAccumulatedBenefitObligation { get; set; }

    [JsonPropertyName("DefinedBenefitPlanActualReturnOnPlanAssets")]
    public DefinedBenefitPlanActualReturnOnPlanAssets DefinedBenefitPlanActualReturnOnPlanAssets { get; set; }

    [JsonPropertyName("DefinedBenefitPlanAssumptionsUsedCalculatingBenefitObligationRateOfCompensationIncrease")]
    public DefinedBenefitPlanAssumptionsUsedCalculatingBenefitObligationRateOfCompensationIncrease DefinedBenefitPlanAssumptionsUsedCalculatingBenefitObligationRateOfCompensationIncrease { get; set; }

    [JsonPropertyName("DefinedBenefitPlanAssumptionsUsedCalculatingNetPeriodicBenefitCostRateOfCompensationIncrease")]
    public DefinedBenefitPlanAssumptionsUsedCalculatingNetPeriodicBenefitCostRateOfCompensationIncrease DefinedBenefitPlanAssumptionsUsedCalculatingNetPeriodicBenefitCostRateOfCompensationIncrease { get; set; }

    [JsonPropertyName("DefinedBenefitPlanBenefitObligation")]
    public DefinedBenefitPlanBenefitObligation DefinedBenefitPlanBenefitObligation { get; set; }

    [JsonPropertyName("DefinedBenefitPlanCostOfProvidingSpecialOrContractualTerminationBenefitRecognizedDuringPeriod")]
    public DefinedBenefitPlanCostOfProvidingSpecialOrContractualTerminationBenefitRecognizedDuringPeriod DefinedBenefitPlanCostOfProvidingSpecialOrContractualTerminationBenefitRecognizedDuringPeriod { get; set; }

    [JsonPropertyName("DefinedBenefitPlanEffectOfOnePercentagePointDecreaseOnAccumulatedPostretirementBenefitObligation1")]
    public DefinedBenefitPlanEffectOfOnePercentagePointDecreaseOnAccumulatedPostretirementBenefitObligation1 DefinedBenefitPlanEffectOfOnePercentagePointDecreaseOnAccumulatedPostretirementBenefitObligation1 { get; set; }

    [JsonPropertyName("DefinedBenefitPlanEffectOfOnePercentagePointDecreaseOnServiceAndInterestCostComponents1")]
    public DefinedBenefitPlanEffectOfOnePercentagePointDecreaseOnServiceAndInterestCostComponents1 DefinedBenefitPlanEffectOfOnePercentagePointDecreaseOnServiceAndInterestCostComponents1 { get; set; }

    [JsonPropertyName("DefinedBenefitPlanEffectOfOnePercentagePointIncreaseOnAccumulatedPostretirementBenefitObligation")]
    public DefinedBenefitPlanEffectOfOnePercentagePointIncreaseOnAccumulatedPostretirementBenefitObligation DefinedBenefitPlanEffectOfOnePercentagePointIncreaseOnAccumulatedPostretirementBenefitObligation { get; set; }

    [JsonPropertyName("DefinedBenefitPlanEffectOfOnePercentagePointIncreaseOnServiceAndInterestCostComponents")]
    public DefinedBenefitPlanEffectOfOnePercentagePointIncreaseOnServiceAndInterestCostComponents DefinedBenefitPlanEffectOfOnePercentagePointIncreaseOnServiceAndInterestCostComponents { get; set; }

    [JsonPropertyName("DefinedBenefitPlanExpectedFutureBenefitPaymentsNextTwelveMonths")]
    public DefinedBenefitPlanExpectedFutureBenefitPaymentsNextTwelveMonths DefinedBenefitPlanExpectedFutureBenefitPaymentsNextTwelveMonths { get; set; }

    [JsonPropertyName("DefinedBenefitPlanExpectedReturnOnPlanAssets")]
    public DefinedBenefitPlanExpectedReturnOnPlanAssets DefinedBenefitPlanExpectedReturnOnPlanAssets { get; set; }

    [JsonPropertyName("DefinedBenefitPlanOtherCosts")]
    public DefinedBenefitPlanOtherCosts DefinedBenefitPlanOtherCosts { get; set; }

    [JsonPropertyName("DefinedBenefitPlanRecognizedNetGainLossDueToSettlements1")]
    public DefinedBenefitPlanRecognizedNetGainLossDueToSettlements1 DefinedBenefitPlanRecognizedNetGainLossDueToSettlements1 { get; set; }

    [JsonPropertyName("DefinedBenefitPlanSettlementsBenefitObligation")]
    public DefinedBenefitPlanSettlementsBenefitObligation DefinedBenefitPlanSettlementsBenefitObligation { get; set; }

    [JsonPropertyName("DefinedBenefitPlanSettlementsPlanAssets")]
    public DefinedBenefitPlanSettlementsPlanAssets DefinedBenefitPlanSettlementsPlanAssets { get; set; }

    [JsonPropertyName("DefinedBenefitPlanUltimateHealthCareCostTrendRate")]
    public DefinedBenefitPlanUltimateHealthCareCostTrendRate DefinedBenefitPlanUltimateHealthCareCostTrendRate { get; set; }

    [JsonPropertyName("DefinedBenefitPlanUltimateHealthCareCostTrendRate1")]
    public DefinedBenefitPlanUltimateHealthCareCostTrendRate1 DefinedBenefitPlanUltimateHealthCareCostTrendRate1 { get; set; }

    [JsonPropertyName("DefinedContributionPlanCostRecognized")]
    public DefinedContributionPlanCostRecognized DefinedContributionPlanCostRecognized { get; set; }

    [JsonPropertyName("Depreciation")]
    public Depreciation Depreciation { get; set; }

    [JsonPropertyName("DepreciationAndAmortization")]
    public DepreciationAndAmortization DepreciationAndAmortization { get; set; }

    [JsonPropertyName("DepreciationDepletionAndAmortization")]
    public DepreciationDepletionAndAmortization DepreciationDepletionAndAmortization { get; set; }

    [JsonPropertyName("DisposalGroupIncludingDiscontinuedOperationCashAndCashEquivalents")]
    public DisposalGroupIncludingDiscontinuedOperationCashAndCashEquivalents DisposalGroupIncludingDiscontinuedOperationCashAndCashEquivalents { get; set; }

    [JsonPropertyName("DisposalGroupIncludingDiscontinuedOperationIntangibleAssetsCurrent")]
    public DisposalGroupIncludingDiscontinuedOperationIntangibleAssetsCurrent DisposalGroupIncludingDiscontinuedOperationIntangibleAssetsCurrent { get; set; }

    [JsonPropertyName("DisposalGroupIncludingDiscontinuedOperationLongLivedAssetsCurrent")]
    public DisposalGroupIncludingDiscontinuedOperationLongLivedAssetsCurrent DisposalGroupIncludingDiscontinuedOperationLongLivedAssetsCurrent { get; set; }

    [JsonPropertyName("DisposalGroupNotDiscontinuedOperationGainLossOnDisposal")]
    public DisposalGroupNotDiscontinuedOperationGainLossOnDisposal DisposalGroupNotDiscontinuedOperationGainLossOnDisposal { get; set; }

    [JsonPropertyName("DividendsCommonStock")]
    public DividendsCommonStock DividendsCommonStock { get; set; }

    [JsonPropertyName("DividendsCommonStockCash")]
    public DividendsCommonStockCash DividendsCommonStockCash { get; set; }

    [JsonPropertyName("DividendsPayableCurrent")]
    public DividendsPayableCurrent DividendsPayableCurrent { get; set; }

    [JsonPropertyName("DividendsPreferredStockCash")]
    public DividendsPreferredStockCash DividendsPreferredStockCash { get; set; }

    [JsonPropertyName("DueFromAffiliateCurrent")]
    public DueFromAffiliateCurrent DueFromAffiliateCurrent { get; set; }

    [JsonPropertyName("EarningsPerShareBasic")]
    public EarningsPerShareBasic EarningsPerShareBasic { get; set; }

    [JsonPropertyName("EarningsPerShareBasicAndDiluted")]
    public EarningsPerShareBasicAndDiluted EarningsPerShareBasicAndDiluted { get; set; }

    [JsonPropertyName("EarningsPerShareDiluted")]
    public EarningsPerShareDiluted EarningsPerShareDiluted { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateContinuingOperations")]
    public EffectiveIncomeTaxRateContinuingOperations EffectiveIncomeTaxRateContinuingOperations { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationAtFederalStatutoryIncomeTaxRate")]
    public EffectiveIncomeTaxRateReconciliationAtFederalStatutoryIncomeTaxRate EffectiveIncomeTaxRateReconciliationAtFederalStatutoryIncomeTaxRate { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationChangeInDeferredTaxAssetsValuationAllowance")]
    public EffectiveIncomeTaxRateReconciliationChangeInDeferredTaxAssetsValuationAllowance EffectiveIncomeTaxRateReconciliationChangeInDeferredTaxAssetsValuationAllowance { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationChangeInEnactedTaxRate")]
    public EffectiveIncomeTaxRateReconciliationChangeInEnactedTaxRate EffectiveIncomeTaxRateReconciliationChangeInEnactedTaxRate { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationDeductionsDividends")]
    public EffectiveIncomeTaxRateReconciliationDeductionsDividends EffectiveIncomeTaxRateReconciliationDeductionsDividends { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationDeductionsOther")]
    public EffectiveIncomeTaxRateReconciliationDeductionsOther EffectiveIncomeTaxRateReconciliationDeductionsOther { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationDispositionOfAssets")]
    public EffectiveIncomeTaxRateReconciliationDispositionOfAssets EffectiveIncomeTaxRateReconciliationDispositionOfAssets { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationForeignIncomeTaxRateDifferential")]
    public EffectiveIncomeTaxRateReconciliationForeignIncomeTaxRateDifferential EffectiveIncomeTaxRateReconciliationForeignIncomeTaxRateDifferential { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationNondeductibleExpenseImpairmentLosses")]
    public EffectiveIncomeTaxRateReconciliationNondeductibleExpenseImpairmentLosses EffectiveIncomeTaxRateReconciliationNondeductibleExpenseImpairmentLosses { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationNondeductibleExpenseLifeInsurance")]
    public EffectiveIncomeTaxRateReconciliationNondeductibleExpenseLifeInsurance EffectiveIncomeTaxRateReconciliationNondeductibleExpenseLifeInsurance { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationNondeductibleExpenseOther")]
    public EffectiveIncomeTaxRateReconciliationNondeductibleExpenseOther EffectiveIncomeTaxRateReconciliationNondeductibleExpenseOther { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationOtherAdjustments")]
    public EffectiveIncomeTaxRateReconciliationOtherAdjustments EffectiveIncomeTaxRateReconciliationOtherAdjustments { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationOtherReconcilingItemsPercent")]
    public EffectiveIncomeTaxRateReconciliationOtherReconcilingItemsPercent EffectiveIncomeTaxRateReconciliationOtherReconcilingItemsPercent { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationStateAndLocalIncomeTaxes")]
    public EffectiveIncomeTaxRateReconciliationStateAndLocalIncomeTaxes EffectiveIncomeTaxRateReconciliationStateAndLocalIncomeTaxes { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationTaxContingencies")]
    public EffectiveIncomeTaxRateReconciliationTaxContingencies EffectiveIncomeTaxRateReconciliationTaxContingencies { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationTaxContingenciesStateAndLocal")]
    public EffectiveIncomeTaxRateReconciliationTaxContingenciesStateAndLocal EffectiveIncomeTaxRateReconciliationTaxContingenciesStateAndLocal { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationTaxCreditsResearch")]
    public EffectiveIncomeTaxRateReconciliationTaxCreditsResearch EffectiveIncomeTaxRateReconciliationTaxCreditsResearch { get; set; }

    [JsonPropertyName("EffectOfExchangeRateOnCashAndCashEquivalents")]
    public EffectOfExchangeRateOnCashAndCashEquivalents EffectOfExchangeRateOnCashAndCashEquivalents { get; set; }

    [JsonPropertyName("EffectOfExchangeRateOnCashAndCashEquivalentsContinuingOperations")]
    public EffectOfExchangeRateOnCashAndCashEquivalentsContinuingOperations EffectOfExchangeRateOnCashAndCashEquivalentsContinuingOperations { get; set; }

    [JsonPropertyName("EmployeeRelatedLiabilitiesCurrent")]
    public EmployeeRelatedLiabilitiesCurrent EmployeeRelatedLiabilitiesCurrent { get; set; }

    [JsonPropertyName("EmployeeServiceShareBasedCompensationCashReceivedFromExerciseOfStockOptions")]
    public EmployeeServiceShareBasedCompensationCashReceivedFromExerciseOfStockOptions EmployeeServiceShareBasedCompensationCashReceivedFromExerciseOfStockOptions { get; set; }

    [JsonPropertyName("EmployeeServiceShareBasedCompensationNonvestedAwardsTotalCompensationCostNotYetRecognized")]
    public EmployeeServiceShareBasedCompensationNonvestedAwardsTotalCompensationCostNotYetRecognized EmployeeServiceShareBasedCompensationNonvestedAwardsTotalCompensationCostNotYetRecognized { get; set; }

    [JsonPropertyName("EmployeeServiceShareBasedCompensationNonvestedAwardsTotalCompensationCostNotYetRecognizedPeriodForRecognition")]
    public EmployeeServiceShareBasedCompensationNonvestedAwardsTotalCompensationCostNotYetRecognizedPeriodForRecognition EmployeeServiceShareBasedCompensationNonvestedAwardsTotalCompensationCostNotYetRecognizedPeriodForRecognition { get; set; }

    [JsonPropertyName("EmployeeServiceShareBasedCompensationTaxBenefitFromCompensationExpense")]
    public EmployeeServiceShareBasedCompensationTaxBenefitFromCompensationExpense EmployeeServiceShareBasedCompensationTaxBenefitFromCompensationExpense { get; set; }

    [JsonPropertyName("EmployeeServiceShareBasedCompensationTaxBenefitRealizedFromExerciseOfStockOptions")]
    public EmployeeServiceShareBasedCompensationTaxBenefitRealizedFromExerciseOfStockOptions EmployeeServiceShareBasedCompensationTaxBenefitRealizedFromExerciseOfStockOptions { get; set; }

    [JsonPropertyName("EmployeeServiceShareBasedCompensationUnrecognizedCompensationCostsOnNonvestedAwards")]
    public EmployeeServiceShareBasedCompensationUnrecognizedCompensationCostsOnNonvestedAwards EmployeeServiceShareBasedCompensationUnrecognizedCompensationCostsOnNonvestedAwards { get; set; }

    [JsonPropertyName("EntityWideInformationRevenueFromExternalCustomerAmount")]
    public EntityWideInformationRevenueFromExternalCustomerAmount EntityWideInformationRevenueFromExternalCustomerAmount { get; set; }

    [JsonPropertyName("EquityMethodInvestmentDividendsOrDistributions")]
    public EquityMethodInvestmentDividendsOrDistributions EquityMethodInvestmentDividendsOrDistributions { get; set; }

    [JsonPropertyName("ExcessTaxBenefitFromShareBasedCompensationFinancingActivities")]
    public ExcessTaxBenefitFromShareBasedCompensationFinancingActivities ExcessTaxBenefitFromShareBasedCompensationFinancingActivities { get; set; }

    [JsonPropertyName("ExcessTaxBenefitFromShareBasedCompensationOperatingActivities")]
    public ExcessTaxBenefitFromShareBasedCompensationOperatingActivities ExcessTaxBenefitFromShareBasedCompensationOperatingActivities { get; set; }

    [JsonPropertyName("ExtraordinaryItemGainOrLossNetOfTaxAttributableToNoncontrollingInterest")]
    public ExtraordinaryItemGainOrLossNetOfTaxAttributableToNoncontrollingInterest ExtraordinaryItemGainOrLossNetOfTaxAttributableToNoncontrollingInterest { get; set; }

    [JsonPropertyName("ExtraordinaryItemGainOrLossNetOfTaxAttributableToReportingEntity")]
    public ExtraordinaryItemGainOrLossNetOfTaxAttributableToReportingEntity ExtraordinaryItemGainOrLossNetOfTaxAttributableToReportingEntity { get; set; }

    [JsonPropertyName("ExtraordinaryItemNetOfTax")]
    public ExtraordinaryItemNetOfTax ExtraordinaryItemNetOfTax { get; set; }

    [JsonPropertyName("ExtraordinaryItemsGross")]
    public ExtraordinaryItemsGross ExtraordinaryItemsGross { get; set; }

    [JsonPropertyName("FairValueFinancialAssetsMeasuredOnRecurringBasisCashSurrenderValue")]
    public FairValueFinancialAssetsMeasuredOnRecurringBasisCashSurrenderValue FairValueFinancialAssetsMeasuredOnRecurringBasisCashSurrenderValue { get; set; }

    [JsonPropertyName("FairValueInputsControlPremium")]
    public FairValueInputsControlPremium FairValueInputsControlPremium { get; set; }

    [JsonPropertyName("FairValueInputsDiscountRate")]
    public FairValueInputsDiscountRate FairValueInputsDiscountRate { get; set; }

    [JsonPropertyName("FinanceLeaseInterestExpense")]
    public FinanceLeaseInterestExpense FinanceLeaseInterestExpense { get; set; }

    [JsonPropertyName("FinanceLeaseInterestPaymentOnLiability")]
    public FinanceLeaseInterestPaymentOnLiability FinanceLeaseInterestPaymentOnLiability { get; set; }

    [JsonPropertyName("FinanceLeaseLiability")]
    public FinanceLeaseLiability FinanceLeaseLiability { get; set; }

    [JsonPropertyName("FinanceLeaseLiabilityCurrent")]
    public FinanceLeaseLiabilityCurrent FinanceLeaseLiabilityCurrent { get; set; }

    [JsonPropertyName("FinanceLeaseLiabilityNoncurrent")]
    public FinanceLeaseLiabilityNoncurrent FinanceLeaseLiabilityNoncurrent { get; set; }

    [JsonPropertyName("FinanceLeaseLiabilityPaymentsDue")]
    public FinanceLeaseLiabilityPaymentsDue FinanceLeaseLiabilityPaymentsDue { get; set; }

    [JsonPropertyName("FinanceLeaseLiabilityPaymentsDueAfterYearFive")]
    public FinanceLeaseLiabilityPaymentsDueAfterYearFive FinanceLeaseLiabilityPaymentsDueAfterYearFive { get; set; }

    [JsonPropertyName("FinanceLeaseLiabilityPaymentsDueNextTwelveMonths")]
    public FinanceLeaseLiabilityPaymentsDueNextTwelveMonths FinanceLeaseLiabilityPaymentsDueNextTwelveMonths { get; set; }

    [JsonPropertyName("FinanceLeaseLiabilityPaymentsDueYearFive")]
    public FinanceLeaseLiabilityPaymentsDueYearFive FinanceLeaseLiabilityPaymentsDueYearFive { get; set; }

    [JsonPropertyName("FinanceLeaseLiabilityPaymentsDueYearFour")]
    public FinanceLeaseLiabilityPaymentsDueYearFour FinanceLeaseLiabilityPaymentsDueYearFour { get; set; }

    [JsonPropertyName("FinanceLeaseLiabilityPaymentsDueYearThree")]
    public FinanceLeaseLiabilityPaymentsDueYearThree FinanceLeaseLiabilityPaymentsDueYearThree { get; set; }

    [JsonPropertyName("FinanceLeaseLiabilityPaymentsDueYearTwo")]
    public FinanceLeaseLiabilityPaymentsDueYearTwo FinanceLeaseLiabilityPaymentsDueYearTwo { get; set; }

    [JsonPropertyName("FinanceLeaseLiabilityPaymentsRemainderOfFiscalYear")]
    public FinanceLeaseLiabilityPaymentsRemainderOfFiscalYear FinanceLeaseLiabilityPaymentsRemainderOfFiscalYear { get; set; }

    [JsonPropertyName("FinanceLeaseLiabilityUndiscountedExcessAmount")]
    public FinanceLeaseLiabilityUndiscountedExcessAmount FinanceLeaseLiabilityUndiscountedExcessAmount { get; set; }

    [JsonPropertyName("FinanceLeasePrincipalPayments")]
    public FinanceLeasePrincipalPayments FinanceLeasePrincipalPayments { get; set; }

    [JsonPropertyName("FinanceLeaseRightOfUseAsset")]
    public FinanceLeaseRightOfUseAsset FinanceLeaseRightOfUseAsset { get; set; }

    [JsonPropertyName("FinanceLeaseRightOfUseAssetAmortization")]
    public FinanceLeaseRightOfUseAssetAmortization FinanceLeaseRightOfUseAssetAmortization { get; set; }

    [JsonPropertyName("FinanceLeaseWeightedAverageDiscountRatePercent")]
    public FinanceLeaseWeightedAverageDiscountRatePercent FinanceLeaseWeightedAverageDiscountRatePercent { get; set; }

    [JsonPropertyName("FinancingReceivableAllowanceForCreditLosses")]
    public FinancingReceivableAllowanceForCreditLosses FinancingReceivableAllowanceForCreditLosses { get; set; }

    [JsonPropertyName("FinancingReceivableAllowanceForCreditLossesRecovery")]
    public FinancingReceivableAllowanceForCreditLossesRecovery FinancingReceivableAllowanceForCreditLossesRecovery { get; set; }

    [JsonPropertyName("FinancingReceivableAllowanceForCreditLossesWriteOffs")]
    public FinancingReceivableAllowanceForCreditLossesWriteOffs FinancingReceivableAllowanceForCreditLossesWriteOffs { get; set; }

    [JsonPropertyName("FinancingReceivableAllowanceForCreditLossForeignCurrencyTranslation")]
    public FinancingReceivableAllowanceForCreditLossForeignCurrencyTranslation FinancingReceivableAllowanceForCreditLossForeignCurrencyTranslation { get; set; }

    [JsonPropertyName("FiniteLivedCustomerListsGross")]
    public FiniteLivedCustomerListsGross FiniteLivedCustomerListsGross { get; set; }

    [JsonPropertyName("FiniteLivedIntangibleAssetsAmortizationExpense")]
    public FiniteLivedIntangibleAssetsAmortizationExpense FiniteLivedIntangibleAssetsAmortizationExpense { get; set; }

    [JsonPropertyName("FiniteLivedIntangibleAssetsAmortizationExpenseNextTwelveMonths")]
    public FiniteLivedIntangibleAssetsAmortizationExpenseNextTwelveMonths FiniteLivedIntangibleAssetsAmortizationExpenseNextTwelveMonths { get; set; }

    [JsonPropertyName("FiniteLivedIntangibleAssetsAmortizationExpenseRemainderOfFiscalYear")]
    public FiniteLivedIntangibleAssetsAmortizationExpenseRemainderOfFiscalYear FiniteLivedIntangibleAssetsAmortizationExpenseRemainderOfFiscalYear { get; set; }

    [JsonPropertyName("FiniteLivedIntangibleAssetsAmortizationExpenseYearFive")]
    public FiniteLivedIntangibleAssetsAmortizationExpenseYearFive FiniteLivedIntangibleAssetsAmortizationExpenseYearFive { get; set; }

    [JsonPropertyName("FiniteLivedIntangibleAssetsAmortizationExpenseYearFour")]
    public FiniteLivedIntangibleAssetsAmortizationExpenseYearFour FiniteLivedIntangibleAssetsAmortizationExpenseYearFour { get; set; }

    [JsonPropertyName("FiniteLivedIntangibleAssetsAmortizationExpenseYearThree")]
    public FiniteLivedIntangibleAssetsAmortizationExpenseYearThree FiniteLivedIntangibleAssetsAmortizationExpenseYearThree { get; set; }

    [JsonPropertyName("FiniteLivedIntangibleAssetsAmortizationExpenseYearTwo")]
    public FiniteLivedIntangibleAssetsAmortizationExpenseYearTwo FiniteLivedIntangibleAssetsAmortizationExpenseYearTwo { get; set; }

    [JsonPropertyName("FiniteLivedIntangibleAssetsNet")]
    public FiniteLivedIntangibleAssetsNet FiniteLivedIntangibleAssetsNet { get; set; }

    [JsonPropertyName("FutureAmortizationExpenseYearFive")]
    public FutureAmortizationExpenseYearFive FutureAmortizationExpenseYearFive { get; set; }

    [JsonPropertyName("FutureAmortizationExpenseYearFour")]
    public FutureAmortizationExpenseYearFour FutureAmortizationExpenseYearFour { get; set; }

    [JsonPropertyName("FutureAmortizationExpenseYearOne")]
    public FutureAmortizationExpenseYearOne FutureAmortizationExpenseYearOne { get; set; }

    [JsonPropertyName("FutureAmortizationExpenseYearThree")]
    public FutureAmortizationExpenseYearThree FutureAmortizationExpenseYearThree { get; set; }

    [JsonPropertyName("FutureAmortizationExpenseYearTwo")]
    public FutureAmortizationExpenseYearTwo FutureAmortizationExpenseYearTwo { get; set; }

    [JsonPropertyName("GainLossOnDispositionOfIntangibleAssets")]
    public GainLossOnDispositionOfIntangibleAssets GainLossOnDispositionOfIntangibleAssets { get; set; }

    [JsonPropertyName("GainLossOnSaleOfBusiness")]
    public GainLossOnSaleOfBusiness GainLossOnSaleOfBusiness { get; set; }

    [JsonPropertyName("GainLossOnSaleOfInvestments")]
    public GainLossOnSaleOfInvestments GainLossOnSaleOfInvestments { get; set; }

    [JsonPropertyName("GainLossOnSaleOfOtherAssets")]
    public GainLossOnSaleOfOtherAssets GainLossOnSaleOfOtherAssets { get; set; }

    [JsonPropertyName("GainLossRelatedToLitigationSettlement")]
    public GainLossRelatedToLitigationSettlement GainLossRelatedToLitigationSettlement { get; set; }

    [JsonPropertyName("GainsLossesOnExtinguishmentOfDebt")]
    public GainsLossesOnExtinguishmentOfDebt GainsLossesOnExtinguishmentOfDebt { get; set; }

    [JsonPropertyName("Goodwill")]
    public Goodwill Goodwill { get; set; }

    [JsonPropertyName("GoodwillAcquiredDuringPeriod")]
    public GoodwillAcquiredDuringPeriod GoodwillAcquiredDuringPeriod { get; set; }

    [JsonPropertyName("GoodwillForeignCurrencyTranslationGainLoss")]
    public GoodwillForeignCurrencyTranslationGainLoss GoodwillForeignCurrencyTranslationGainLoss { get; set; }

    [JsonPropertyName("GoodwillImpairedAccumulatedImpairmentLoss")]
    public GoodwillImpairedAccumulatedImpairmentLoss GoodwillImpairedAccumulatedImpairmentLoss { get; set; }

    [JsonPropertyName("GoodwillImpairmentLoss")]
    public GoodwillImpairmentLoss GoodwillImpairmentLoss { get; set; }

    [JsonPropertyName("GoodwillPurchaseAccountingAdjustments")]
    public GoodwillPurchaseAccountingAdjustments GoodwillPurchaseAccountingAdjustments { get; set; }

    [JsonPropertyName("GoodwillTransfers")]
    public GoodwillTransfers GoodwillTransfers { get; set; }

    [JsonPropertyName("ImpairmentOfIntangibleAssetsIndefinitelivedExcludingGoodwill")]
    public ImpairmentOfIntangibleAssetsIndefinitelivedExcludingGoodwill ImpairmentOfIntangibleAssetsIndefinitelivedExcludingGoodwill { get; set; }

    [JsonPropertyName("ImpairmentOfLongLivedAssetsToBeDisposedOf")]
    public ImpairmentOfLongLivedAssetsToBeDisposedOf ImpairmentOfLongLivedAssetsToBeDisposedOf { get; set; }

    [JsonPropertyName("IncomeLossBeforeExtraordinaryItemsAndCumulativeEffectOfChangeInAccountingPrinciple")]
    public IncomeLossBeforeExtraordinaryItemsAndCumulativeEffectOfChangeInAccountingPrinciple IncomeLossBeforeExtraordinaryItemsAndCumulativeEffectOfChangeInAccountingPrinciple { get; set; }

    [JsonPropertyName("IncomeLossBeforeExtraordinaryItemsAndCumulativeEffectOfChangeInAccountingPrinciplePerBasicShare")]
    public IncomeLossBeforeExtraordinaryItemsAndCumulativeEffectOfChangeInAccountingPrinciplePerBasicShare IncomeLossBeforeExtraordinaryItemsAndCumulativeEffectOfChangeInAccountingPrinciplePerBasicShare { get; set; }

    [JsonPropertyName("IncomeLossBeforeExtraordinaryItemsAndCumulativeEffectOfChangeInAccountingPrinciplePerDilutedShare")]
    public IncomeLossBeforeExtraordinaryItemsAndCumulativeEffectOfChangeInAccountingPrinciplePerDilutedShare IncomeLossBeforeExtraordinaryItemsAndCumulativeEffectOfChangeInAccountingPrinciplePerDilutedShare { get; set; }

    [JsonPropertyName("IncomeLossFromContinuingOperations")]
    public IncomeLossFromContinuingOperations IncomeLossFromContinuingOperations { get; set; }

    [JsonPropertyName("IncomeLossFromContinuingOperationsBeforeIncomeTaxesExtraordinaryItemsNoncontrollingInterest")]
    public IncomeLossFromContinuingOperationsBeforeIncomeTaxesExtraordinaryItemsNoncontrollingInterest IncomeLossFromContinuingOperationsBeforeIncomeTaxesExtraordinaryItemsNoncontrollingInterest { get; set; }

    [JsonPropertyName("IncomeLossFromContinuingOperationsBeforeIncomeTaxesMinorityInterestAndIncomeLossFromEquityMethodInvestments")]
    public IncomeLossFromContinuingOperationsBeforeIncomeTaxesMinorityInterestAndIncomeLossFromEquityMethodInvestments IncomeLossFromContinuingOperationsBeforeIncomeTaxesMinorityInterestAndIncomeLossFromEquityMethodInvestments { get; set; }

    [JsonPropertyName("IncomeLossFromEquityMethodInvestments")]
    public IncomeLossFromEquityMethodInvestments IncomeLossFromEquityMethodInvestments { get; set; }

    [JsonPropertyName("IncomeLossFromExtraordinaryItemsNetOfTaxPerBasicAndDilutedShare")]
    public IncomeLossFromExtraordinaryItemsNetOfTaxPerBasicAndDilutedShare IncomeLossFromExtraordinaryItemsNetOfTaxPerBasicAndDilutedShare { get; set; }

    [JsonPropertyName("IncomeLossFromExtraordinaryItemsNetOfTaxPerBasicShare")]
    public IncomeLossFromExtraordinaryItemsNetOfTaxPerBasicShare IncomeLossFromExtraordinaryItemsNetOfTaxPerBasicShare { get; set; }

    [JsonPropertyName("IncomeLossFromExtraordinaryItemsNetOfTaxPerDilutedShare")]
    public IncomeLossFromExtraordinaryItemsNetOfTaxPerDilutedShare IncomeLossFromExtraordinaryItemsNetOfTaxPerDilutedShare { get; set; }

    [JsonPropertyName("IncomeLossFromOperationsBeforeExtraordinaryItemsPerBasicAndDilutedShare")]
    public IncomeLossFromOperationsBeforeExtraordinaryItemsPerBasicAndDilutedShare IncomeLossFromOperationsBeforeExtraordinaryItemsPerBasicAndDilutedShare { get; set; }

    [JsonPropertyName("IncomeTaxEffectsAllocatedDirectlyToEquityEmployeeStockOptions")]
    public IncomeTaxEffectsAllocatedDirectlyToEquityEmployeeStockOptions IncomeTaxEffectsAllocatedDirectlyToEquityEmployeeStockOptions { get; set; }

    [JsonPropertyName("IncomeTaxExpenseBenefit")]
    public IncomeTaxExpenseBenefit IncomeTaxExpenseBenefit { get; set; }

    [JsonPropertyName("IncomeTaxExpenseBenefitContinuingOperations")]
    public IncomeTaxExpenseBenefitContinuingOperations IncomeTaxExpenseBenefitContinuingOperations { get; set; }

    [JsonPropertyName("IncomeTaxExpenseBenefitExtraordinaryItems")]
    public IncomeTaxExpenseBenefitExtraordinaryItems IncomeTaxExpenseBenefitExtraordinaryItems { get; set; }

    [JsonPropertyName("IncomeTaxesPaid")]
    public IncomeTaxesPaid IncomeTaxesPaid { get; set; }

    [JsonPropertyName("IncomeTaxesPaidNet")]
    public IncomeTaxesPaidNet IncomeTaxesPaidNet { get; set; }

    [JsonPropertyName("IncomeTaxesReceivable")]
    public IncomeTaxesReceivable IncomeTaxesReceivable { get; set; }

    [JsonPropertyName("IncomeTaxReceivable")]
    public IncomeTaxReceivable IncomeTaxReceivable { get; set; }

    [JsonPropertyName("IncomeTaxReconciliationChangeInDeferredTaxAssetsValuationAllowance")]
    public IncomeTaxReconciliationChangeInDeferredTaxAssetsValuationAllowance IncomeTaxReconciliationChangeInDeferredTaxAssetsValuationAllowance { get; set; }

    [JsonPropertyName("IncomeTaxReconciliationDeductionsDividends")]
    public IncomeTaxReconciliationDeductionsDividends IncomeTaxReconciliationDeductionsDividends { get; set; }

    [JsonPropertyName("IncomeTaxReconciliationDeductionsOther")]
    public IncomeTaxReconciliationDeductionsOther IncomeTaxReconciliationDeductionsOther { get; set; }

    [JsonPropertyName("IncomeTaxReconciliationDispositionOfAssets")]
    public IncomeTaxReconciliationDispositionOfAssets IncomeTaxReconciliationDispositionOfAssets { get; set; }

    [JsonPropertyName("IncomeTaxReconciliationNondeductibleExpense")]
    public IncomeTaxReconciliationNondeductibleExpense IncomeTaxReconciliationNondeductibleExpense { get; set; }

    [JsonPropertyName("IncomeTaxReconciliationNondeductibleExpenseImpairmentLosses")]
    public IncomeTaxReconciliationNondeductibleExpenseImpairmentLosses IncomeTaxReconciliationNondeductibleExpenseImpairmentLosses { get; set; }

    [JsonPropertyName("IncomeTaxReconciliationNondeductibleExpenseLifeInsurance")]
    public IncomeTaxReconciliationNondeductibleExpenseLifeInsurance IncomeTaxReconciliationNondeductibleExpenseLifeInsurance { get; set; }

    [JsonPropertyName("IncomeTaxReconciliationOtherAdjustments")]
    public IncomeTaxReconciliationOtherAdjustments IncomeTaxReconciliationOtherAdjustments { get; set; }

    [JsonPropertyName("IncomeTaxReconciliationTaxContingencies")]
    public IncomeTaxReconciliationTaxContingencies IncomeTaxReconciliationTaxContingencies { get; set; }

    [JsonPropertyName("IncomeTaxReconciliationTaxContingenciesStateAndLocal")]
    public IncomeTaxReconciliationTaxContingenciesStateAndLocal IncomeTaxReconciliationTaxContingenciesStateAndLocal { get; set; }

    [JsonPropertyName("IncomeTaxReconciliationTaxCreditsResearch")]
    public IncomeTaxReconciliationTaxCreditsResearch IncomeTaxReconciliationTaxCreditsResearch { get; set; }

    [JsonPropertyName("IncomeTaxReconciliationTaxSettlements")]
    public IncomeTaxReconciliationTaxSettlements IncomeTaxReconciliationTaxSettlements { get; set; }

    [JsonPropertyName("IncomeTaxReconciliationTaxSettlementsDomestic")]
    public IncomeTaxReconciliationTaxSettlementsDomestic IncomeTaxReconciliationTaxSettlementsDomestic { get; set; }

    [JsonPropertyName("IncreaseDecreaseInAccountsPayable")]
    public IncreaseDecreaseInAccountsPayable IncreaseDecreaseInAccountsPayable { get; set; }

    [JsonPropertyName("IncreaseDecreaseInAccountsReceivable")]
    public IncreaseDecreaseInAccountsReceivable IncreaseDecreaseInAccountsReceivable { get; set; }

    [JsonPropertyName("IncreaseDecreaseInAccruedTaxesPayable")]
    public IncreaseDecreaseInAccruedTaxesPayable IncreaseDecreaseInAccruedTaxesPayable { get; set; }

    [JsonPropertyName("IncreaseDecreaseInOtherCurrentAssets")]
    public IncreaseDecreaseInOtherCurrentAssets IncreaseDecreaseInOtherCurrentAssets { get; set; }

    [JsonPropertyName("IncreaseDecreaseInOtherCurrentAssetsAndLiabilitiesNet")]
    public IncreaseDecreaseInOtherCurrentAssetsAndLiabilitiesNet IncreaseDecreaseInOtherCurrentAssetsAndLiabilitiesNet { get; set; }

    [JsonPropertyName("IncreaseDecreaseInOtherNoncurrentAssetsAndLiabilitiesNet")]
    public IncreaseDecreaseInOtherNoncurrentAssetsAndLiabilitiesNet IncreaseDecreaseInOtherNoncurrentAssetsAndLiabilitiesNet { get; set; }

    [JsonPropertyName("IncreaseDecreaseInOtherOperatingCapitalNet")]
    public IncreaseDecreaseInOtherOperatingCapitalNet IncreaseDecreaseInOtherOperatingCapitalNet { get; set; }

    [JsonPropertyName("IncreaseDecreaseInPensionAndPostretirementObligations")]
    public IncreaseDecreaseInPensionAndPostretirementObligations IncreaseDecreaseInPensionAndPostretirementObligations { get; set; }

    [JsonPropertyName("IncrementalCommonSharesAttributableToConversionOfDebtSecurities")]
    public IncrementalCommonSharesAttributableToConversionOfDebtSecurities IncrementalCommonSharesAttributableToConversionOfDebtSecurities { get; set; }

    [JsonPropertyName("IncrementalCommonSharesAttributableToShareBasedPaymentArrangements")]
    public IncrementalCommonSharesAttributableToShareBasedPaymentArrangements IncrementalCommonSharesAttributableToShareBasedPaymentArrangements { get; set; }

    [JsonPropertyName("IndefiniteLivedIntangibleAssetsExcludingGoodwill")]
    public IndefiniteLivedIntangibleAssetsExcludingGoodwill IndefiniteLivedIntangibleAssetsExcludingGoodwill { get; set; }

    [JsonPropertyName("IntangibleAssetsNetExcludingGoodwill")]
    public IntangibleAssetsNetExcludingGoodwill IntangibleAssetsNetExcludingGoodwill { get; set; }

    [JsonPropertyName("IntangibleAssetsNetIncludingGoodwill")]
    public IntangibleAssetsNetIncludingGoodwill IntangibleAssetsNetIncludingGoodwill { get; set; }

    [JsonPropertyName("InterestAndDividendsPayableCurrent")]
    public InterestAndDividendsPayableCurrent InterestAndDividendsPayableCurrent { get; set; }

    [JsonPropertyName("InterestCostsCapitalized")]
    public InterestCostsCapitalized InterestCostsCapitalized { get; set; }

    [JsonPropertyName("InterestCostsIncurred")]
    public InterestCostsIncurred InterestCostsIncurred { get; set; }

    [JsonPropertyName("InterestExpense")]
    public InterestExpense InterestExpense { get; set; }

    [JsonPropertyName("InterestExpenseDebt")]
    public InterestExpenseDebt InterestExpenseDebt { get; set; }

    [JsonPropertyName("InterestPaidCapitalized")]
    public InterestPaidCapitalized InterestPaidCapitalized { get; set; }

    [JsonPropertyName("InterestPaidNet")]
    public InterestPaidNet InterestPaidNet { get; set; }

    [JsonPropertyName("InterestPayableCurrent")]
    public InterestPayableCurrent InterestPayableCurrent { get; set; }

    [JsonPropertyName("InventoryNet")]
    public InventoryNet InventoryNet { get; set; }

    [JsonPropertyName("LeaseAndRentalExpense")]
    public LeaseAndRentalExpense LeaseAndRentalExpense { get; set; }

    [JsonPropertyName("LeaseCost")]
    public LeaseCost LeaseCost { get; set; }

    [JsonPropertyName("LesseeOperatingLeaseLiabilityPaymentsDue")]
    public LesseeOperatingLeaseLiabilityPaymentsDue LesseeOperatingLeaseLiabilityPaymentsDue { get; set; }

    [JsonPropertyName("LesseeOperatingLeaseLiabilityPaymentsDueAfterYearFive")]
    public LesseeOperatingLeaseLiabilityPaymentsDueAfterYearFive LesseeOperatingLeaseLiabilityPaymentsDueAfterYearFive { get; set; }

    [JsonPropertyName("LesseeOperatingLeaseLiabilityPaymentsDueNextRollingTwelveMonths")]
    public LesseeOperatingLeaseLiabilityPaymentsDueNextRollingTwelveMonths LesseeOperatingLeaseLiabilityPaymentsDueNextRollingTwelveMonths { get; set; }

    [JsonPropertyName("LesseeOperatingLeaseLiabilityPaymentsDueNextTwelveMonths")]
    public LesseeOperatingLeaseLiabilityPaymentsDueNextTwelveMonths LesseeOperatingLeaseLiabilityPaymentsDueNextTwelveMonths { get; set; }

    [JsonPropertyName("LesseeOperatingLeaseLiabilityPaymentsDueYearFive")]
    public LesseeOperatingLeaseLiabilityPaymentsDueYearFive LesseeOperatingLeaseLiabilityPaymentsDueYearFive { get; set; }

    [JsonPropertyName("LesseeOperatingLeaseLiabilityPaymentsDueYearFour")]
    public LesseeOperatingLeaseLiabilityPaymentsDueYearFour LesseeOperatingLeaseLiabilityPaymentsDueYearFour { get; set; }

    [JsonPropertyName("LesseeOperatingLeaseLiabilityPaymentsDueYearThree")]
    public LesseeOperatingLeaseLiabilityPaymentsDueYearThree LesseeOperatingLeaseLiabilityPaymentsDueYearThree { get; set; }

    [JsonPropertyName("LesseeOperatingLeaseLiabilityPaymentsDueYearTwo")]
    public LesseeOperatingLeaseLiabilityPaymentsDueYearTwo LesseeOperatingLeaseLiabilityPaymentsDueYearTwo { get; set; }

    [JsonPropertyName("LesseeOperatingLeaseLiabilityPaymentsRemainderOfFiscalYear")]
    public LesseeOperatingLeaseLiabilityPaymentsRemainderOfFiscalYear LesseeOperatingLeaseLiabilityPaymentsRemainderOfFiscalYear { get; set; }

    [JsonPropertyName("LesseeOperatingLeaseLiabilityUndiscountedExcessAmount")]
    public LesseeOperatingLeaseLiabilityUndiscountedExcessAmount LesseeOperatingLeaseLiabilityUndiscountedExcessAmount { get; set; }

    [JsonPropertyName("LettersOfCreditOutstandingAmount")]
    public LettersOfCreditOutstandingAmount LettersOfCreditOutstandingAmount { get; set; }

    [JsonPropertyName("LiabilitiesAndStockholdersEquity")]
    public LiabilitiesAndStockholdersEquity LiabilitiesAndStockholdersEquity { get; set; }

    [JsonPropertyName("LiabilitiesCurrent")]
    public LiabilitiesCurrent LiabilitiesCurrent { get; set; }

    [JsonPropertyName("LiabilitiesOfDisposalGroupIncludingDiscontinuedOperationCurrent")]
    public LiabilitiesOfDisposalGroupIncludingDiscontinuedOperationCurrent LiabilitiesOfDisposalGroupIncludingDiscontinuedOperationCurrent { get; set; }

    [JsonPropertyName("LiabilitiesOtherThanLongtermDebtNoncurrent")]
    public LiabilitiesOtherThanLongtermDebtNoncurrent LiabilitiesOtherThanLongtermDebtNoncurrent { get; set; }

    [JsonPropertyName("LiabilityForUncertainTaxPositionsNoncurrent")]
    public LiabilityForUncertainTaxPositionsNoncurrent LiabilityForUncertainTaxPositionsNoncurrent { get; set; }

    [JsonPropertyName("LitigationReserve")]
    public LitigationReserve LitigationReserve { get; set; }

    [JsonPropertyName("LitigationReserveCurrent")]
    public LitigationReserveCurrent LitigationReserveCurrent { get; set; }

    [JsonPropertyName("LongTermDebt")]
    public LongTermDebt LongTermDebt { get; set; }

    [JsonPropertyName("LongTermDebtAndCapitalLeaseObligations")]
    public LongTermDebtAndCapitalLeaseObligations LongTermDebtAndCapitalLeaseObligations { get; set; }

    [JsonPropertyName("LongTermDebtAndCapitalLeaseObligationsCurrent")]
    public LongTermDebtAndCapitalLeaseObligationsCurrent LongTermDebtAndCapitalLeaseObligationsCurrent { get; set; }

    [JsonPropertyName("LongTermDebtAndCapitalLeaseObligationsIncludingCurrentMaturities")]
    public LongTermDebtAndCapitalLeaseObligationsIncludingCurrentMaturities LongTermDebtAndCapitalLeaseObligationsIncludingCurrentMaturities { get; set; }

    [JsonPropertyName("LongTermDebtCurrent")]
    public LongTermDebtCurrent LongTermDebtCurrent { get; set; }

    [JsonPropertyName("LongTermDebtMaturitiesRepaymentsOfPrincipalAfterYearFive")]
    public LongTermDebtMaturitiesRepaymentsOfPrincipalAfterYearFive LongTermDebtMaturitiesRepaymentsOfPrincipalAfterYearFive { get; set; }

    [JsonPropertyName("LongTermDebtMaturitiesRepaymentsOfPrincipalInNextTwelveMonths")]
    public LongTermDebtMaturitiesRepaymentsOfPrincipalInNextTwelveMonths LongTermDebtMaturitiesRepaymentsOfPrincipalInNextTwelveMonths { get; set; }

    [JsonPropertyName("LongTermDebtMaturitiesRepaymentsOfPrincipalInYearFive")]
    public LongTermDebtMaturitiesRepaymentsOfPrincipalInYearFive LongTermDebtMaturitiesRepaymentsOfPrincipalInYearFive { get; set; }

    [JsonPropertyName("LongTermDebtMaturitiesRepaymentsOfPrincipalInYearFour")]
    public LongTermDebtMaturitiesRepaymentsOfPrincipalInYearFour LongTermDebtMaturitiesRepaymentsOfPrincipalInYearFour { get; set; }

    [JsonPropertyName("LongTermDebtMaturitiesRepaymentsOfPrincipalInYearThree")]
    public LongTermDebtMaturitiesRepaymentsOfPrincipalInYearThree LongTermDebtMaturitiesRepaymentsOfPrincipalInYearThree { get; set; }

    [JsonPropertyName("LongTermDebtMaturitiesRepaymentsOfPrincipalInYearTwo")]
    public LongTermDebtMaturitiesRepaymentsOfPrincipalInYearTwo LongTermDebtMaturitiesRepaymentsOfPrincipalInYearTwo { get; set; }

    [JsonPropertyName("LongTermDebtMaturitiesRepaymentsOfPrincipalRemainderOfFiscalYear")]
    public LongTermDebtMaturitiesRepaymentsOfPrincipalRemainderOfFiscalYear LongTermDebtMaturitiesRepaymentsOfPrincipalRemainderOfFiscalYear { get; set; }

    [JsonPropertyName("LossContingencyEstimateOfPossibleLoss")]
    public LossContingencyEstimateOfPossibleLoss LossContingencyEstimateOfPossibleLoss { get; set; }

    [JsonPropertyName("LossContingencyNewClaimsFiledNumber")]
    public LossContingencyNewClaimsFiledNumber LossContingencyNewClaimsFiledNumber { get; set; }

    [JsonPropertyName("LossContingencyNumberOfPlaintiffs")]
    public LossContingencyNumberOfPlaintiffs LossContingencyNumberOfPlaintiffs { get; set; }

    [JsonPropertyName("LossContingencyPatentsAllegedlyInfringedNumber")]
    public LossContingencyPatentsAllegedlyInfringedNumber LossContingencyPatentsAllegedlyInfringedNumber { get; set; }

    [JsonPropertyName("MarketableSecuritiesRealizedGainLoss")]
    public MarketableSecuritiesRealizedGainLoss MarketableSecuritiesRealizedGainLoss { get; set; }

    [JsonPropertyName("MaterialsSuppliesAndOther")]
    public MaterialsSuppliesAndOther MaterialsSuppliesAndOther { get; set; }

    [JsonPropertyName("MinorityInterest")]
    public MinorityInterest MinorityInterest { get; set; }

    [JsonPropertyName("MinorityInterestDecreaseFromDistributionsToNoncontrollingInterestHolders")]
    public MinorityInterestDecreaseFromDistributionsToNoncontrollingInterestHolders MinorityInterestDecreaseFromDistributionsToNoncontrollingInterestHolders { get; set; }

    [JsonPropertyName("MinorityInterestInNetIncomeLossJointVenturePartners")]
    public MinorityInterestInNetIncomeLossJointVenturePartners MinorityInterestInNetIncomeLossJointVenturePartners { get; set; }

    [JsonPropertyName("NetCashProvidedByUsedInContinuingOperations")]
    public NetCashProvidedByUsedInContinuingOperations NetCashProvidedByUsedInContinuingOperations { get; set; }

    [JsonPropertyName("NetCashProvidedByUsedInFinancingActivities")]
    public NetCashProvidedByUsedInFinancingActivities NetCashProvidedByUsedInFinancingActivities { get; set; }

    [JsonPropertyName("NetCashProvidedByUsedInFinancingActivitiesContinuingOperations")]
    public NetCashProvidedByUsedInFinancingActivitiesContinuingOperations NetCashProvidedByUsedInFinancingActivitiesContinuingOperations { get; set; }

    [JsonPropertyName("NetCashProvidedByUsedInInvestingActivities")]
    public NetCashProvidedByUsedInInvestingActivities NetCashProvidedByUsedInInvestingActivities { get; set; }

    [JsonPropertyName("NetCashProvidedByUsedInInvestingActivitiesContinuingOperations")]
    public NetCashProvidedByUsedInInvestingActivitiesContinuingOperations NetCashProvidedByUsedInInvestingActivitiesContinuingOperations { get; set; }

    [JsonPropertyName("NetCashProvidedByUsedInOperatingActivities")]
    public NetCashProvidedByUsedInOperatingActivities NetCashProvidedByUsedInOperatingActivities { get; set; }

    [JsonPropertyName("NetCashProvidedByUsedInOperatingActivitiesContinuingOperations")]
    public NetCashProvidedByUsedInOperatingActivitiesContinuingOperations NetCashProvidedByUsedInOperatingActivitiesContinuingOperations { get; set; }

    [JsonPropertyName("NetIncomeLoss")]
    public NetIncomeLoss NetIncomeLoss { get; set; }

    [JsonPropertyName("NetIncomeLossAttributableToNoncontrollingInterest")]
    public NetIncomeLossAttributableToNoncontrollingInterest NetIncomeLossAttributableToNoncontrollingInterest { get; set; }

    [JsonPropertyName("NetIncomeLossAvailableToCommonStockholdersBasic")]
    public NetIncomeLossAvailableToCommonStockholdersBasic NetIncomeLossAvailableToCommonStockholdersBasic { get; set; }

    [JsonPropertyName("NetIncomeLossAvailableToCommonStockholdersDiluted")]
    public NetIncomeLossAvailableToCommonStockholdersDiluted NetIncomeLossAvailableToCommonStockholdersDiluted { get; set; }

    [JsonPropertyName("NonoperatingIncomeExpense")]
    public NonoperatingIncomeExpense NonoperatingIncomeExpense { get; set; }

    [JsonPropertyName("NumberOfOperatingSegments")]
    public NumberOfOperatingSegments NumberOfOperatingSegments { get; set; }

    [JsonPropertyName("NumberOfReportableSegments")]
    public NumberOfReportableSegments NumberOfReportableSegments { get; set; }

    [JsonPropertyName("NumberOfReportingUnits")]
    public NumberOfReportingUnits NumberOfReportingUnits { get; set; }

    [JsonPropertyName("OciBeforeReclassificationsNetOfTaxAttributableToParent")]
    public OciBeforeReclassificationsNetOfTaxAttributableToParent OciBeforeReclassificationsNetOfTaxAttributableToParent { get; set; }

    [JsonPropertyName("OperatingCostsAndExpenses")]
    public OperatingCostsAndExpenses OperatingCostsAndExpenses { get; set; }

    [JsonPropertyName("OperatingExpenses")]
    public OperatingExpenses OperatingExpenses { get; set; }

    [JsonPropertyName("OperatingIncomeLoss")]
    public OperatingIncomeLoss OperatingIncomeLoss { get; set; }

    [JsonPropertyName("OperatingLeaseCost")]
    public OperatingLeaseCost OperatingLeaseCost { get; set; }

    [JsonPropertyName("OperatingLeaseLeaseIncome")]
    public OperatingLeaseLeaseIncome OperatingLeaseLeaseIncome { get; set; }

    [JsonPropertyName("OperatingLeaseLiability")]
    public OperatingLeaseLiability OperatingLeaseLiability { get; set; }

    [JsonPropertyName("OperatingLeaseLiabilityCurrent")]
    public OperatingLeaseLiabilityCurrent OperatingLeaseLiabilityCurrent { get; set; }

    [JsonPropertyName("OperatingLeaseLiabilityNoncurrent")]
    public OperatingLeaseLiabilityNoncurrent OperatingLeaseLiabilityNoncurrent { get; set; }

    [JsonPropertyName("OperatingLeasePayments")]
    public OperatingLeasePayments OperatingLeasePayments { get; set; }

    [JsonPropertyName("OperatingLeaseRightOfUseAsset")]
    public OperatingLeaseRightOfUseAsset OperatingLeaseRightOfUseAsset { get; set; }

    [JsonPropertyName("OperatingLeasesFutureMinimumPaymentsDue")]
    public OperatingLeasesFutureMinimumPaymentsDue OperatingLeasesFutureMinimumPaymentsDue { get; set; }

    [JsonPropertyName("OperatingLeasesFutureMinimumPaymentsDueCurrent")]
    public OperatingLeasesFutureMinimumPaymentsDueCurrent OperatingLeasesFutureMinimumPaymentsDueCurrent { get; set; }

    [JsonPropertyName("OperatingLeasesFutureMinimumPaymentsDueFutureMinimumSubleaseRentals")]
    public OperatingLeasesFutureMinimumPaymentsDueFutureMinimumSubleaseRentals OperatingLeasesFutureMinimumPaymentsDueFutureMinimumSubleaseRentals { get; set; }

    [JsonPropertyName("OperatingLeasesFutureMinimumPaymentsDueInFiveYears")]
    public OperatingLeasesFutureMinimumPaymentsDueInFiveYears OperatingLeasesFutureMinimumPaymentsDueInFiveYears { get; set; }

    [JsonPropertyName("OperatingLeasesFutureMinimumPaymentsDueInFourYears")]
    public OperatingLeasesFutureMinimumPaymentsDueInFourYears OperatingLeasesFutureMinimumPaymentsDueInFourYears { get; set; }

    [JsonPropertyName("OperatingLeasesFutureMinimumPaymentsDueInThreeYears")]
    public OperatingLeasesFutureMinimumPaymentsDueInThreeYears OperatingLeasesFutureMinimumPaymentsDueInThreeYears { get; set; }

    [JsonPropertyName("OperatingLeasesFutureMinimumPaymentsDueInTwoYears")]
    public OperatingLeasesFutureMinimumPaymentsDueInTwoYears OperatingLeasesFutureMinimumPaymentsDueInTwoYears { get; set; }

    [JsonPropertyName("OperatingLeasesFutureMinimumPaymentsDueThereafter")]
    public OperatingLeasesFutureMinimumPaymentsDueThereafter OperatingLeasesFutureMinimumPaymentsDueThereafter { get; set; }

    [JsonPropertyName("OperatingLeasesIncomeStatementSubleaseRevenue")]
    public OperatingLeasesIncomeStatementSubleaseRevenue OperatingLeasesIncomeStatementSubleaseRevenue { get; set; }

    [JsonPropertyName("OperatingLeasesRentExpenseSubleaseRentals1")]
    public OperatingLeasesRentExpenseSubleaseRentals1 OperatingLeasesRentExpenseSubleaseRentals1 { get; set; }

    [JsonPropertyName("OperatingLeaseWeightedAverageDiscountRatePercent")]
    public OperatingLeaseWeightedAverageDiscountRatePercent OperatingLeaseWeightedAverageDiscountRatePercent { get; set; }

    [JsonPropertyName("OperatingLossCarryforwards")]
    public OperatingLossCarryforwards OperatingLossCarryforwards { get; set; }

    [JsonPropertyName("OperatingLossCarryforwardsValuationAllowance")]
    public OperatingLossCarryforwardsValuationAllowance OperatingLossCarryforwardsValuationAllowance { get; set; }

    [JsonPropertyName("OtherAssetImpairmentCharges")]
    public OtherAssetImpairmentCharges OtherAssetImpairmentCharges { get; set; }

    [JsonPropertyName("OtherAssets")]
    public OtherAssets OtherAssets { get; set; }

    [JsonPropertyName("OtherAssetsCurrent")]
    public OtherAssetsCurrent OtherAssetsCurrent { get; set; }

    [JsonPropertyName("OtherAssetsMiscellaneousCurrent")]
    public OtherAssetsMiscellaneousCurrent OtherAssetsMiscellaneousCurrent { get; set; }

    [JsonPropertyName("OtherAssetsNoncurrent")]
    public OtherAssetsNoncurrent OtherAssetsNoncurrent { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeAmortizationOfDefinedBenefitPlanNetPriorServiceCostRecognizedInNetPeriodicPensionCostNetOfTax")]
    public OtherComprehensiveIncomeAmortizationOfDefinedBenefitPlanNetPriorServiceCostRecognizedInNetPeriodicPensionCostNetOfTax OtherComprehensiveIncomeAmortizationOfDefinedBenefitPlanNetPriorServiceCostRecognizedInNetPeriodicPensionCostNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeAmortizationOfDefinedBenefitPlanNetPriorServiceCostRecognizedInNetPeriodicPensionCostTax")]
    public OtherComprehensiveIncomeAmortizationOfDefinedBenefitPlanNetPriorServiceCostRecognizedInNetPeriodicPensionCostTax OtherComprehensiveIncomeAmortizationOfDefinedBenefitPlanNetPriorServiceCostRecognizedInNetPeriodicPensionCostTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeAvailableforsaleSecuritiesAdjustmentNetOfTaxPortionAttributableToParent")]
    public OtherComprehensiveIncomeAvailableforsaleSecuritiesAdjustmentNetOfTaxPortionAttributableToParent OtherComprehensiveIncomeAvailableforsaleSecuritiesAdjustmentNetOfTaxPortionAttributableToParent { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeAvailableforsaleSecuritiesTaxPortionAttributableToParent")]
    public OtherComprehensiveIncomeAvailableforsaleSecuritiesTaxPortionAttributableToParent OtherComprehensiveIncomeAvailableforsaleSecuritiesTaxPortionAttributableToParent { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeDefinedBenefitPlanNetPriorServiceCostsArisingDuringPeriodTax")]
    public OtherComprehensiveIncomeDefinedBenefitPlanNetPriorServiceCostsArisingDuringPeriodTax OtherComprehensiveIncomeDefinedBenefitPlanNetPriorServiceCostsArisingDuringPeriodTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeDefinedBenefitPlanNetPriorServiceCostsCreditArisingDuringPeriodNetOfTax")]
    public OtherComprehensiveIncomeDefinedBenefitPlanNetPriorServiceCostsCreditArisingDuringPeriodNetOfTax OtherComprehensiveIncomeDefinedBenefitPlanNetPriorServiceCostsCreditArisingDuringPeriodNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeDefinedBenefitPlansAdjustmentNetOfTaxPeriodIncreaseDecrease")]
    public OtherComprehensiveIncomeDefinedBenefitPlansAdjustmentNetOfTaxPeriodIncreaseDecrease OtherComprehensiveIncomeDefinedBenefitPlansAdjustmentNetOfTaxPeriodIncreaseDecrease { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeDefinedBenefitPlansAdjustmentNetOfTaxPortionAttributableToParent")]
    public OtherComprehensiveIncomeDefinedBenefitPlansAdjustmentNetOfTaxPortionAttributableToParent OtherComprehensiveIncomeDefinedBenefitPlansAdjustmentNetOfTaxPortionAttributableToParent { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeDefinedBenefitPlansNetUnamortizedGainLossArisingDuringPeriodNetOfTax")]
    public OtherComprehensiveIncomeDefinedBenefitPlansNetUnamortizedGainLossArisingDuringPeriodNetOfTax OtherComprehensiveIncomeDefinedBenefitPlansNetUnamortizedGainLossArisingDuringPeriodNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeDefinedBenefitPlansNetUnamortizedGainLossArisingDuringPeriodTax")]
    public OtherComprehensiveIncomeDefinedBenefitPlansNetUnamortizedGainLossArisingDuringPeriodTax OtherComprehensiveIncomeDefinedBenefitPlansNetUnamortizedGainLossArisingDuringPeriodTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeDefinedBenefitPlansTax")]
    public OtherComprehensiveIncomeDefinedBenefitPlansTax OtherComprehensiveIncomeDefinedBenefitPlansTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeDefinedBenefitPlansTaxPortionAttributableToParent")]
    public OtherComprehensiveIncomeDefinedBenefitPlansTaxPortionAttributableToParent OtherComprehensiveIncomeDefinedBenefitPlansTaxPortionAttributableToParent { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeDerivativesQualifyingAsHedgesNetOfTaxPeriodIncreaseDecrease")]
    public OtherComprehensiveIncomeDerivativesQualifyingAsHedgesNetOfTaxPeriodIncreaseDecrease OtherComprehensiveIncomeDerivativesQualifyingAsHedgesNetOfTaxPeriodIncreaseDecrease { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeDerivativesQualifyingAsHedgesNetOfTaxPortionAttributableToParent")]
    public OtherComprehensiveIncomeDerivativesQualifyingAsHedgesNetOfTaxPortionAttributableToParent OtherComprehensiveIncomeDerivativesQualifyingAsHedgesNetOfTaxPortionAttributableToParent { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeFinalizationOfPensionAndNonPensionPostretirementPlanValuationTax")]
    public OtherComprehensiveIncomeFinalizationOfPensionAndNonPensionPostretirementPlanValuationTax OtherComprehensiveIncomeFinalizationOfPensionAndNonPensionPostretirementPlanValuationTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeForeignCurrencyTransactionAndTranslationAdjustmentNetOfTaxPortionAttributableToParent")]
    public OtherComprehensiveIncomeForeignCurrencyTransactionAndTranslationAdjustmentNetOfTaxPortionAttributableToParent OtherComprehensiveIncomeForeignCurrencyTransactionAndTranslationAdjustmentNetOfTaxPortionAttributableToParent { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeForeignCurrencyTranslationAdjustmentTaxPortionAttributableToParent")]
    public OtherComprehensiveIncomeForeignCurrencyTranslationAdjustmentTaxPortionAttributableToParent OtherComprehensiveIncomeForeignCurrencyTranslationAdjustmentTaxPortionAttributableToParent { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossAmortizationAdjustmentFromAOCIPensionAndOtherPostretirementBenefitPlansForNetPriorServiceCostCreditNetOfTax")]
    public OtherComprehensiveIncomeLossAmortizationAdjustmentFromAOCIPensionAndOtherPostretirementBenefitPlansForNetPriorServiceCostCreditNetOfTax OtherComprehensiveIncomeLossAmortizationAdjustmentFromAOCIPensionAndOtherPostretirementBenefitPlansForNetPriorServiceCostCreditNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossAmortizationAdjustmentFromAOCIPensionAndOtherPostretirementBenefitPlansForNetPriorServiceCostCreditTax")]
    public OtherComprehensiveIncomeLossAmortizationAdjustmentFromAOCIPensionAndOtherPostretirementBenefitPlansForNetPriorServiceCostCreditTax OtherComprehensiveIncomeLossAmortizationAdjustmentFromAOCIPensionAndOtherPostretirementBenefitPlansForNetPriorServiceCostCreditTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossAmortizationPensionAndOtherPostretirementBenefitPlansNetPriorServiceCostRecognizedInNetPeriodicPensionCostTaxEffect")]
    public OtherComprehensiveIncomeLossAmortizationPensionAndOtherPostretirementBenefitPlansNetPriorServiceCostRecognizedInNetPeriodicPensionCostTaxEffect OtherComprehensiveIncomeLossAmortizationPensionAndOtherPostretirementBenefitPlansNetPriorServiceCostRecognizedInNetPeriodicPensionCostTaxEffect { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossBeforeReclassificationsNetOfTax")]
    public OtherComprehensiveIncomeLossBeforeReclassificationsNetOfTax OtherComprehensiveIncomeLossBeforeReclassificationsNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossCashFlowHedgeGainLossAfterReclassificationAndTaxParent")]
    public OtherComprehensiveIncomeLossCashFlowHedgeGainLossAfterReclassificationAndTaxParent OtherComprehensiveIncomeLossCashFlowHedgeGainLossAfterReclassificationAndTaxParent { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossCashFlowHedgeGainLossAfterReclassificationTax")]
    public OtherComprehensiveIncomeLossCashFlowHedgeGainLossAfterReclassificationTax OtherComprehensiveIncomeLossCashFlowHedgeGainLossAfterReclassificationTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossCashFlowHedgeGainLossReclassificationAfterTax")]
    public OtherComprehensiveIncomeLossCashFlowHedgeGainLossReclassificationAfterTax OtherComprehensiveIncomeLossCashFlowHedgeGainLossReclassificationAfterTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossCashFlowHedgeGainLossReclassificationTax")]
    public OtherComprehensiveIncomeLossCashFlowHedgeGainLossReclassificationTax OtherComprehensiveIncomeLossCashFlowHedgeGainLossReclassificationTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossDerivativesQualifyingAsHedgesNetOfTax")]
    public OtherComprehensiveIncomeLossDerivativesQualifyingAsHedgesNetOfTax OtherComprehensiveIncomeLossDerivativesQualifyingAsHedgesNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossDerivativesQualifyingAsHedgesTax")]
    public OtherComprehensiveIncomeLossDerivativesQualifyingAsHedgesTax OtherComprehensiveIncomeLossDerivativesQualifyingAsHedgesTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossFinalizationOfPensionAndNonPensionPostretirementPlanValuationNetOfTax")]
    public OtherComprehensiveIncomeLossFinalizationOfPensionAndNonPensionPostretirementPlanValuationNetOfTax OtherComprehensiveIncomeLossFinalizationOfPensionAndNonPensionPostretirementPlanValuationNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossForeignCurrencyTransactionAndTranslationAdjustmentNetOfTax")]
    public OtherComprehensiveIncomeLossForeignCurrencyTransactionAndTranslationAdjustmentNetOfTax OtherComprehensiveIncomeLossForeignCurrencyTransactionAndTranslationAdjustmentNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossForeignCurrencyTranslationAdjustmentTax")]
    public OtherComprehensiveIncomeLossForeignCurrencyTranslationAdjustmentTax OtherComprehensiveIncomeLossForeignCurrencyTranslationAdjustmentTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossNetOfTax")]
    public OtherComprehensiveIncomeLossNetOfTax OtherComprehensiveIncomeLossNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossNetOfTaxPeriodIncreaseDecrease")]
    public OtherComprehensiveIncomeLossNetOfTaxPeriodIncreaseDecrease OtherComprehensiveIncomeLossNetOfTaxPeriodIncreaseDecrease { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossNetOfTaxPortionAttributableToParent")]
    public OtherComprehensiveIncomeLossNetOfTaxPortionAttributableToParent OtherComprehensiveIncomeLossNetOfTaxPortionAttributableToParent { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossPensionAndOtherPostretirementBenefitPlansBenefitPlanImprovementTaxEffect")]
    public OtherComprehensiveIncomeLossPensionAndOtherPostretirementBenefitPlansBenefitPlanImprovementTaxEffect OtherComprehensiveIncomeLossPensionAndOtherPostretirementBenefitPlansBenefitPlanImprovementTaxEffect { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossReclassificationAdjustmentForSaleOfSecuritiesIncludedInNetIncomeNetOfTax")]
    public OtherComprehensiveIncomeLossReclassificationAdjustmentForSaleOfSecuritiesIncludedInNetIncomeNetOfTax OtherComprehensiveIncomeLossReclassificationAdjustmentForSaleOfSecuritiesIncludedInNetIncomeNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossReclassificationAdjustmentForSaleOfSecuritiesIncludedInNetIncomeTax")]
    public OtherComprehensiveIncomeLossReclassificationAdjustmentForSaleOfSecuritiesIncludedInNetIncomeTax OtherComprehensiveIncomeLossReclassificationAdjustmentForSaleOfSecuritiesIncludedInNetIncomeTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossReclassificationAdjustmentFromAOCIForSaleOfSecuritiesNetOfTax")]
    public OtherComprehensiveIncomeLossReclassificationAdjustmentFromAOCIForSaleOfSecuritiesNetOfTax OtherComprehensiveIncomeLossReclassificationAdjustmentFromAOCIForSaleOfSecuritiesNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossReclassificationAdjustmentFromAOCIForSaleOfSecuritiesTax")]
    public OtherComprehensiveIncomeLossReclassificationAdjustmentFromAOCIForSaleOfSecuritiesTax OtherComprehensiveIncomeLossReclassificationAdjustmentFromAOCIForSaleOfSecuritiesTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossReclassificationAdjustmentFromAOCIOnDerivativesNetOfTax")]
    public OtherComprehensiveIncomeLossReclassificationAdjustmentFromAOCIOnDerivativesNetOfTax OtherComprehensiveIncomeLossReclassificationAdjustmentFromAOCIOnDerivativesNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossReclassificationAdjustmentFromAOCIPensionAndOtherPostretirementBenefitPlansForNetGainLossNetOfTax")]
    public OtherComprehensiveIncomeLossReclassificationAdjustmentFromAOCIPensionAndOtherPostretirementBenefitPlansForNetGainLossNetOfTax OtherComprehensiveIncomeLossReclassificationAdjustmentFromAOCIPensionAndOtherPostretirementBenefitPlansForNetGainLossNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossReclassificationAdjustmentFromAOCIPensionAndOtherPostretirementBenefitPlansForNetGainLossTax")]
    public OtherComprehensiveIncomeLossReclassificationAdjustmentFromAOCIPensionAndOtherPostretirementBenefitPlansForNetGainLossTax OtherComprehensiveIncomeLossReclassificationAdjustmentFromAOCIPensionAndOtherPostretirementBenefitPlansForNetGainLossTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossTax")]
    public OtherComprehensiveIncomeLossTax OtherComprehensiveIncomeLossTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeReclassificationAdjustmentForHeldToMaturityTransferredToAvailableForSaleSecuritiesNetOfTax")]
    public OtherComprehensiveIncomeReclassificationAdjustmentForHeldToMaturityTransferredToAvailableForSaleSecuritiesNetOfTax OtherComprehensiveIncomeReclassificationAdjustmentForHeldToMaturityTransferredToAvailableForSaleSecuritiesNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeReclassificationAdjustmentForHeldToMaturityTransferredToAvailableForSaleSecuritiesTax")]
    public OtherComprehensiveIncomeReclassificationAdjustmentForHeldToMaturityTransferredToAvailableForSaleSecuritiesTax OtherComprehensiveIncomeReclassificationAdjustmentForHeldToMaturityTransferredToAvailableForSaleSecuritiesTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeReclassificationAdjustmentForSaleOfSecuritiesIncludedInNetIncomeNetOfTax")]
    public OtherComprehensiveIncomeReclassificationAdjustmentForSaleOfSecuritiesIncludedInNetIncomeNetOfTax OtherComprehensiveIncomeReclassificationAdjustmentForSaleOfSecuritiesIncludedInNetIncomeNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeReclassificationAdjustmentForSaleOfSecuritiesIncludedInNetIncomeTax")]
    public OtherComprehensiveIncomeReclassificationAdjustmentForSaleOfSecuritiesIncludedInNetIncomeTax OtherComprehensiveIncomeReclassificationAdjustmentForSaleOfSecuritiesIncludedInNetIncomeTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeReclassificationAdjustmentOnDerivativesIncludedInNetIncomeNetOfTax")]
    public OtherComprehensiveIncomeReclassificationAdjustmentOnDerivativesIncludedInNetIncomeNetOfTax OtherComprehensiveIncomeReclassificationAdjustmentOnDerivativesIncludedInNetIncomeNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeReclassificationAdjustmentOnDerivativesIncludedInNetIncomeTax")]
    public OtherComprehensiveIncomeReclassificationAdjustmentOnDerivativesIncludedInNetIncomeTax OtherComprehensiveIncomeReclassificationAdjustmentOnDerivativesIncludedInNetIncomeTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeReclassificationOfDefinedBenefitPlansNetGainLossRecognizedInNetPeriodicBenefitCostNetOfTax")]
    public OtherComprehensiveIncomeReclassificationOfDefinedBenefitPlansNetGainLossRecognizedInNetPeriodicBenefitCostNetOfTax OtherComprehensiveIncomeReclassificationOfDefinedBenefitPlansNetGainLossRecognizedInNetPeriodicBenefitCostNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeReclassificationOfDefinedBenefitPlansNetGainLossRecognizedInNetPeriodicBenefitCostTax")]
    public OtherComprehensiveIncomeReclassificationOfDefinedBenefitPlansNetGainLossRecognizedInNetPeriodicBenefitCostTax OtherComprehensiveIncomeReclassificationOfDefinedBenefitPlansNetGainLossRecognizedInNetPeriodicBenefitCostTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeUnrealizedGainLossOnDerivativesArisingDuringPeriodNetOfTax")]
    public OtherComprehensiveIncomeUnrealizedGainLossOnDerivativesArisingDuringPeriodNetOfTax OtherComprehensiveIncomeUnrealizedGainLossOnDerivativesArisingDuringPeriodNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeUnrealizedHoldingGainLossOnSecuritiesArisingDuringPeriodNetOfTax")]
    public OtherComprehensiveIncomeUnrealizedHoldingGainLossOnSecuritiesArisingDuringPeriodNetOfTax OtherComprehensiveIncomeUnrealizedHoldingGainLossOnSecuritiesArisingDuringPeriodNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeUnrealizedHoldingGainLossOnSecuritiesArisingDuringPeriodTax")]
    public OtherComprehensiveIncomeUnrealizedHoldingGainLossOnSecuritiesArisingDuringPeriodTax OtherComprehensiveIncomeUnrealizedHoldingGainLossOnSecuritiesArisingDuringPeriodTax { get; set; }

    [JsonPropertyName("OtherDeferredCostsNet")]
    public OtherDeferredCostsNet OtherDeferredCostsNet { get; set; }

    [JsonPropertyName("OtherDeferredCreditsNoncurrent")]
    public OtherDeferredCreditsNoncurrent OtherDeferredCreditsNoncurrent { get; set; }

    [JsonPropertyName("OtherFiniteLivedIntangibleAssetsGross")]
    public OtherFiniteLivedIntangibleAssetsGross OtherFiniteLivedIntangibleAssetsGross { get; set; }

    [JsonPropertyName("OtherIntangibleAssetsNet")]
    public OtherIntangibleAssetsNet OtherIntangibleAssetsNet { get; set; }

    [JsonPropertyName("OtherLiabilitiesCurrent")]
    public OtherLiabilitiesCurrent OtherLiabilitiesCurrent { get; set; }

    [JsonPropertyName("OtherLiabilitiesNoncurrent")]
    public OtherLiabilitiesNoncurrent OtherLiabilitiesNoncurrent { get; set; }

    [JsonPropertyName("OtherNonoperatingIncomeExpense")]
    public OtherNonoperatingIncomeExpense OtherNonoperatingIncomeExpense { get; set; }

    [JsonPropertyName("OtherOperatingActivitiesCashFlowStatement")]
    public OtherOperatingActivitiesCashFlowStatement OtherOperatingActivitiesCashFlowStatement { get; set; }

    [JsonPropertyName("OtherPaymentsToAcquireBusinesses")]
    public OtherPaymentsToAcquireBusinesses OtherPaymentsToAcquireBusinesses { get; set; }

    [JsonPropertyName("OtherPostretirementDefinedBenefitPlanLiabilitiesNoncurrent")]
    public OtherPostretirementDefinedBenefitPlanLiabilitiesNoncurrent OtherPostretirementDefinedBenefitPlanLiabilitiesNoncurrent { get; set; }

    [JsonPropertyName("OtherReceivablesGrossCurrent")]
    public OtherReceivablesGrossCurrent OtherReceivablesGrossCurrent { get; set; }

    [JsonPropertyName("OtherSundryLiabilitiesCurrent")]
    public OtherSundryLiabilitiesCurrent OtherSundryLiabilitiesCurrent { get; set; }

    [JsonPropertyName("PaymentsForOtherOperatingActivities")]
    public PaymentsForOtherOperatingActivities PaymentsForOtherOperatingActivities { get; set; }

    [JsonPropertyName("PaymentsForProceedsFromHedgeInvestingActivities")]
    public PaymentsForProceedsFromHedgeInvestingActivities PaymentsForProceedsFromHedgeInvestingActivities { get; set; }

    [JsonPropertyName("PaymentsForProceedsFromInvestments")]
    public PaymentsForProceedsFromInvestments PaymentsForProceedsFromInvestments { get; set; }

    [JsonPropertyName("PaymentsForProceedsFromOtherInvestingActivities")]
    public PaymentsForProceedsFromOtherInvestingActivities PaymentsForProceedsFromOtherInvestingActivities { get; set; }

    [JsonPropertyName("PaymentsForRepurchaseOfCommonStock")]
    public PaymentsForRepurchaseOfCommonStock PaymentsForRepurchaseOfCommonStock { get; set; }

    [JsonPropertyName("PaymentsForRestructuring")]
    public PaymentsForRestructuring PaymentsForRestructuring { get; set; }

    [JsonPropertyName("PaymentsOfDebtExtinguishmentCosts")]
    public PaymentsOfDebtExtinguishmentCosts PaymentsOfDebtExtinguishmentCosts { get; set; }

    [JsonPropertyName("PaymentsOfDividends")]
    public PaymentsOfDividends PaymentsOfDividends { get; set; }

    [JsonPropertyName("PaymentsOfDividendsCommonStock")]
    public PaymentsOfDividendsCommonStock PaymentsOfDividendsCommonStock { get; set; }

    [JsonPropertyName("PaymentsToAcquireBusinessesGross")]
    public PaymentsToAcquireBusinessesGross PaymentsToAcquireBusinessesGross { get; set; }

    [JsonPropertyName("PaymentsToAcquireBusinessesNetOfCashAcquired")]
    public PaymentsToAcquireBusinessesNetOfCashAcquired PaymentsToAcquireBusinessesNetOfCashAcquired { get; set; }

    [JsonPropertyName("PaymentsToAcquireBusinessTwoNetOfCashAcquired")]
    public PaymentsToAcquireBusinessTwoNetOfCashAcquired PaymentsToAcquireBusinessTwoNetOfCashAcquired { get; set; }

    [JsonPropertyName("PaymentsToAcquireProductiveAssets")]
    public PaymentsToAcquireProductiveAssets PaymentsToAcquireProductiveAssets { get; set; }

    [JsonPropertyName("PaymentsToAcquirePropertyPlantAndEquipment")]
    public PaymentsToAcquirePropertyPlantAndEquipment PaymentsToAcquirePropertyPlantAndEquipment { get; set; }

    [JsonPropertyName("PensionAndOtherPostretirementDefinedBenefitPlansLiabilitiesNoncurrent")]
    public PensionAndOtherPostretirementDefinedBenefitPlansLiabilitiesNoncurrent PensionAndOtherPostretirementDefinedBenefitPlansLiabilitiesNoncurrent { get; set; }

    [JsonPropertyName("PostemploymentBenefitsLiabilityNoncurrent")]
    public PostemploymentBenefitsLiabilityNoncurrent PostemploymentBenefitsLiabilityNoncurrent { get; set; }

    [JsonPropertyName("PreferredStockDividends")]
    public PreferredStockDividends PreferredStockDividends { get; set; }

    [JsonPropertyName("PreferredStockDividendsPerShareDeclared")]
    public PreferredStockDividendsPerShareDeclared PreferredStockDividendsPerShareDeclared { get; set; }

    [JsonPropertyName("PreferredStockParOrStatedValuePerShare")]
    public PreferredStockParOrStatedValuePerShare PreferredStockParOrStatedValuePerShare { get; set; }

    [JsonPropertyName("PreferredStockSharesAuthorized")]
    public PreferredStockSharesAuthorized PreferredStockSharesAuthorized { get; set; }

    [JsonPropertyName("PreferredStockSharesIssued")]
    public PreferredStockSharesIssued PreferredStockSharesIssued { get; set; }

    [JsonPropertyName("PreferredStockSharesOutstanding")]
    public PreferredStockSharesOutstanding PreferredStockSharesOutstanding { get; set; }

    [JsonPropertyName("PreferredStockValue")]
    public PreferredStockValue PreferredStockValue { get; set; }

    [JsonPropertyName("PrepaidExpenseCurrent")]
    public PrepaidExpenseCurrent PrepaidExpenseCurrent { get; set; }

    [JsonPropertyName("PrescriptionDrugSubsidyReceiptsAfterYearFive")]
    public PrescriptionDrugSubsidyReceiptsAfterYearFive PrescriptionDrugSubsidyReceiptsAfterYearFive { get; set; }

    [JsonPropertyName("PrescriptionDrugSubsidyReceiptsNextTwelveMonths")]
    public PrescriptionDrugSubsidyReceiptsNextTwelveMonths PrescriptionDrugSubsidyReceiptsNextTwelveMonths { get; set; }

    [JsonPropertyName("PrescriptionDrugSubsidyReceiptsYearFive1")]
    public PrescriptionDrugSubsidyReceiptsYearFive1 PrescriptionDrugSubsidyReceiptsYearFive1 { get; set; }

    [JsonPropertyName("PrescriptionDrugSubsidyReceiptsYearFour1")]
    public PrescriptionDrugSubsidyReceiptsYearFour1 PrescriptionDrugSubsidyReceiptsYearFour1 { get; set; }

    [JsonPropertyName("PrescriptionDrugSubsidyReceiptsYearThree1")]
    public PrescriptionDrugSubsidyReceiptsYearThree1 PrescriptionDrugSubsidyReceiptsYearThree1 { get; set; }

    [JsonPropertyName("PrescriptionDrugSubsidyReceiptsYearTwo1")]
    public PrescriptionDrugSubsidyReceiptsYearTwo1 PrescriptionDrugSubsidyReceiptsYearTwo1 { get; set; }

    [JsonPropertyName("PriorPeriodReclassificationAdjustment")]
    public PriorPeriodReclassificationAdjustment PriorPeriodReclassificationAdjustment { get; set; }

    [JsonPropertyName("ProceedsFromDivestitureOfBusinesses")]
    public ProceedsFromDivestitureOfBusinesses ProceedsFromDivestitureOfBusinesses { get; set; }

    [JsonPropertyName("ProceedsFromIncomeTaxRefunds")]
    public ProceedsFromIncomeTaxRefunds ProceedsFromIncomeTaxRefunds { get; set; }

    [JsonPropertyName("ProceedsFromIssuanceOfCommonStock")]
    public ProceedsFromIssuanceOfCommonStock ProceedsFromIssuanceOfCommonStock { get; set; }

    [JsonPropertyName("ProceedsFromIssuanceOfLongTermDebt")]
    public ProceedsFromIssuanceOfLongTermDebt ProceedsFromIssuanceOfLongTermDebt { get; set; }

    [JsonPropertyName("ProceedsFromLinesOfCredit")]
    public ProceedsFromLinesOfCredit ProceedsFromLinesOfCredit { get; set; }

    [JsonPropertyName("ProceedsFromPaymentsForOtherFinancingActivities")]
    public ProceedsFromPaymentsForOtherFinancingActivities ProceedsFromPaymentsForOtherFinancingActivities { get; set; }

    [JsonPropertyName("ProceedsFromRentsReceived")]
    public ProceedsFromRentsReceived ProceedsFromRentsReceived { get; set; }

    [JsonPropertyName("ProceedsFromRepaymentsOfLinesOfCredit")]
    public ProceedsFromRepaymentsOfLinesOfCredit ProceedsFromRepaymentsOfLinesOfCredit { get; set; }

    [JsonPropertyName("ProceedsFromRepaymentsOfOtherLongTermDebt")]
    public ProceedsFromRepaymentsOfOtherLongTermDebt ProceedsFromRepaymentsOfOtherLongTermDebt { get; set; }

    [JsonPropertyName("ProceedsFromSaleAndMaturityOfMarketableSecurities")]
    public ProceedsFromSaleAndMaturityOfMarketableSecurities ProceedsFromSaleAndMaturityOfMarketableSecurities { get; set; }

    [JsonPropertyName("ProceedsFromSaleOfIntangibleAssets")]
    public ProceedsFromSaleOfIntangibleAssets ProceedsFromSaleOfIntangibleAssets { get; set; }

    [JsonPropertyName("ProceedsFromSaleOfProductiveAssets")]
    public ProceedsFromSaleOfProductiveAssets ProceedsFromSaleOfProductiveAssets { get; set; }

    [JsonPropertyName("ProceedsFromSaleOfPropertyHeldForSale")]
    public ProceedsFromSaleOfPropertyHeldForSale ProceedsFromSaleOfPropertyHeldForSale { get; set; }

    [JsonPropertyName("ProfitLoss")]
    public ProfitLoss ProfitLoss { get; set; }

    [JsonPropertyName("PropertyPlantAndEquipmentGross")]
    public PropertyPlantAndEquipmentGross PropertyPlantAndEquipmentGross { get; set; }

    [JsonPropertyName("PropertyPlantAndEquipmentNet")]
    public PropertyPlantAndEquipmentNet PropertyPlantAndEquipmentNet { get; set; }

    [JsonPropertyName("PropertyPlantAndEquipmentOther")]
    public PropertyPlantAndEquipmentOther PropertyPlantAndEquipmentOther { get; set; }

    [JsonPropertyName("ProvisionForDoubtfulAccounts")]
    public ProvisionForDoubtfulAccounts ProvisionForDoubtfulAccounts { get; set; }

    [JsonPropertyName("ProvisionForLoanLossesExpensed")]
    public ProvisionForLoanLossesExpensed ProvisionForLoanLossesExpensed { get; set; }

    [JsonPropertyName("PurchaseCommitmentRemainingMinimumAmountCommitted")]
    public PurchaseCommitmentRemainingMinimumAmountCommitted PurchaseCommitmentRemainingMinimumAmountCommitted { get; set; }

    [JsonPropertyName("PurchaseObligationDueAfterFifthYear")]
    public PurchaseObligationDueAfterFifthYear PurchaseObligationDueAfterFifthYear { get; set; }

    [JsonPropertyName("PurchaseObligationDueInFourthAndFifthYear")]
    public PurchaseObligationDueInFourthAndFifthYear PurchaseObligationDueInFourthAndFifthYear { get; set; }

    [JsonPropertyName("PurchaseObligationDueInNextTwelveMonths")]
    public PurchaseObligationDueInNextTwelveMonths PurchaseObligationDueInNextTwelveMonths { get; set; }

    [JsonPropertyName("PurchaseObligationDueInSecondAndThirdYear")]
    public PurchaseObligationDueInSecondAndThirdYear PurchaseObligationDueInSecondAndThirdYear { get; set; }

    [JsonPropertyName("ReclassificationFromAccumulatedOtherComprehensiveIncomeCurrentPeriodNetOfTax")]
    public ReclassificationFromAccumulatedOtherComprehensiveIncomeCurrentPeriodNetOfTax ReclassificationFromAccumulatedOtherComprehensiveIncomeCurrentPeriodNetOfTax { get; set; }

    [JsonPropertyName("ReclassificationFromAociCurrentPeriodNetOfTaxAttributableToParent")]
    public ReclassificationFromAociCurrentPeriodNetOfTaxAttributableToParent ReclassificationFromAociCurrentPeriodNetOfTaxAttributableToParent { get; set; }

    [JsonPropertyName("RepaymentsOfDebt")]
    public RepaymentsOfDebt RepaymentsOfDebt { get; set; }

    [JsonPropertyName("RepaymentsOfLinesOfCredit")]
    public RepaymentsOfLinesOfCredit RepaymentsOfLinesOfCredit { get; set; }

    [JsonPropertyName("RepaymentsOfLongTermCapitalLeaseObligations")]
    public RepaymentsOfLongTermCapitalLeaseObligations RepaymentsOfLongTermCapitalLeaseObligations { get; set; }

    [JsonPropertyName("RepaymentsOfLongTermDebt")]
    public RepaymentsOfLongTermDebt RepaymentsOfLongTermDebt { get; set; }

    [JsonPropertyName("RepaymentsOfLongTermLinesOfCredit")]
    public RepaymentsOfLongTermLinesOfCredit RepaymentsOfLongTermLinesOfCredit { get; set; }

    [JsonPropertyName("RestrictedCashAndInvestmentsCurrent")]
    public RestrictedCashAndInvestmentsCurrent RestrictedCashAndInvestmentsCurrent { get; set; }

    [JsonPropertyName("RestrictedCashAndInvestmentsNoncurrent")]
    public RestrictedCashAndInvestmentsNoncurrent RestrictedCashAndInvestmentsNoncurrent { get; set; }

    [JsonPropertyName("RestrictedCashCurrent")]
    public RestrictedCashCurrent RestrictedCashCurrent { get; set; }

    [JsonPropertyName("RestrictedCashNoncurrent")]
    public RestrictedCashNoncurrent RestrictedCashNoncurrent { get; set; }

    [JsonPropertyName("RestructuringCharges")]
    public RestructuringCharges RestructuringCharges { get; set; }

    [JsonPropertyName("RetainedEarningsAccumulatedDeficit")]
    public RetainedEarningsAccumulatedDeficit RetainedEarningsAccumulatedDeficit { get; set; }

    [JsonPropertyName("RevenueFromContractWithCustomerExcludingAssessedTax")]
    public RevenueFromContractWithCustomerExcludingAssessedTax RevenueFromContractWithCustomerExcludingAssessedTax { get; set; }

    [JsonPropertyName("RevenueFromContractWithCustomerIncludingAssessedTax")]
    public RevenueFromContractWithCustomerIncludingAssessedTax RevenueFromContractWithCustomerIncludingAssessedTax { get; set; }

    [JsonPropertyName("RevenueNotFromContractWithCustomer")]
    public RevenueNotFromContractWithCustomer RevenueNotFromContractWithCustomer { get; set; }

    [JsonPropertyName("RevenueRemainingPerformanceObligation")]
    public RevenueRemainingPerformanceObligation RevenueRemainingPerformanceObligation { get; set; }

    [JsonPropertyName("RevenueRemainingPerformanceObligationPercentage")]
    public RevenueRemainingPerformanceObligationPercentage RevenueRemainingPerformanceObligationPercentage { get; set; }

    [JsonPropertyName("Revenues")]
    public Revenues Revenues { get; set; }

    [JsonPropertyName("RightOfUseAssetObtainedInExchangeForFinanceLeaseLiability")]
    public RightOfUseAssetObtainedInExchangeForFinanceLeaseLiability RightOfUseAssetObtainedInExchangeForFinanceLeaseLiability { get; set; }

    [JsonPropertyName("RightOfUseAssetObtainedInExchangeForOperatingLeaseLiability")]
    public RightOfUseAssetObtainedInExchangeForOperatingLeaseLiability RightOfUseAssetObtainedInExchangeForOperatingLeaseLiability { get; set; }

    [JsonPropertyName("SaleLeasebackTransactionNetProceedsFinancingActivities")]
    public SaleLeasebackTransactionNetProceedsFinancingActivities SaleLeasebackTransactionNetProceedsFinancingActivities { get; set; }

    [JsonPropertyName("SaleLeasebackTransactionNetProceedsInvestingActivities")]
    public SaleLeasebackTransactionNetProceedsInvestingActivities SaleLeasebackTransactionNetProceedsInvestingActivities { get; set; }

    [JsonPropertyName("SaleLeasebackTransactionRentExpense")]
    public SaleLeasebackTransactionRentExpense SaleLeasebackTransactionRentExpense { get; set; }

    [JsonPropertyName("SaleOfStockPricePerShare")]
    public SaleOfStockPricePerShare SaleOfStockPricePerShare { get; set; }

    [JsonPropertyName("SegmentReportingInformationRevenue")]
    public SegmentReportingInformationRevenue SegmentReportingInformationRevenue { get; set; }

    [JsonPropertyName("SellingGeneralAndAdministrativeExpense")]
    public SellingGeneralAndAdministrativeExpense SellingGeneralAndAdministrativeExpense { get; set; }

    [JsonPropertyName("SeveranceCosts")]
    public SeveranceCosts SeveranceCosts { get; set; }

    [JsonPropertyName("SeveranceCosts1")]
    public SeveranceCosts1 SeveranceCosts1 { get; set; }

    [JsonPropertyName("ShareBasedCompensation")]
    public ShareBasedCompensation ShareBasedCompensation { get; set; }

    [JsonPropertyName("ShareBasedCompensationArrangementByShareBasedPaymentAwardDiscountFromMarketPricePurchaseDate")]
    public ShareBasedCompensationArrangementByShareBasedPaymentAwardDiscountFromMarketPricePurchaseDate ShareBasedCompensationArrangementByShareBasedPaymentAwardDiscountFromMarketPricePurchaseDate { get; set; }

    [JsonPropertyName("ShareBasedCompensationArrangementByShareBasedPaymentAwardEquityInstrumentsOtherThanOptionsVestedInPeriodTotalFairValue")]
    public ShareBasedCompensationArrangementByShareBasedPaymentAwardEquityInstrumentsOtherThanOptionsVestedInPeriodTotalFairValue ShareBasedCompensationArrangementByShareBasedPaymentAwardEquityInstrumentsOtherThanOptionsVestedInPeriodTotalFairValue { get; set; }

    [JsonPropertyName("ShareBasedCompensationArrangementByShareBasedPaymentAwardNumberOfSharesAvailableForGrant")]
    public ShareBasedCompensationArrangementByShareBasedPaymentAwardNumberOfSharesAvailableForGrant ShareBasedCompensationArrangementByShareBasedPaymentAwardNumberOfSharesAvailableForGrant { get; set; }

    [JsonPropertyName("ShareBasedCompensationArrangementByShareBasedPaymentAwardOptionsExercisableWeightedAverageExercisePrice")]
    public ShareBasedCompensationArrangementByShareBasedPaymentAwardOptionsExercisableWeightedAverageExercisePrice ShareBasedCompensationArrangementByShareBasedPaymentAwardOptionsExercisableWeightedAverageExercisePrice { get; set; }

    [JsonPropertyName("ShareBasedCompensationArrangementByShareBasedPaymentAwardOptionsExercisesInPeriodTotalIntrinsicValue")]
    public ShareBasedCompensationArrangementByShareBasedPaymentAwardOptionsExercisesInPeriodTotalIntrinsicValue ShareBasedCompensationArrangementByShareBasedPaymentAwardOptionsExercisesInPeriodTotalIntrinsicValue { get; set; }

    [JsonPropertyName("ShareBasedCompensationArrangementByShareBasedPaymentAwardOptionsOutstandingNumber")]
    public ShareBasedCompensationArrangementByShareBasedPaymentAwardOptionsOutstandingNumber ShareBasedCompensationArrangementByShareBasedPaymentAwardOptionsOutstandingNumber { get; set; }

    [JsonPropertyName("SharePrice")]
    public SharePrice SharePrice { get; set; }

    [JsonPropertyName("SignificantChangeInUnrecognizedTaxBenefitsIsReasonablyPossibleAmountOfUnrecordedBenefit")]
    public SignificantChangeInUnrecognizedTaxBenefitsIsReasonablyPossibleAmountOfUnrecordedBenefit SignificantChangeInUnrecognizedTaxBenefitsIsReasonablyPossibleAmountOfUnrecordedBenefit { get; set; }

    [JsonPropertyName("SignificantPurchaseCommitmentRemainingMinimumAmountCommitted")]
    public SignificantPurchaseCommitmentRemainingMinimumAmountCommitted SignificantPurchaseCommitmentRemainingMinimumAmountCommitted { get; set; }

    [JsonPropertyName("StockholdersEquity")]
    public StockholdersEquity StockholdersEquity { get; set; }

    [JsonPropertyName("StockholdersEquityIncludingPortionAttributableToNoncontrollingInterest")]
    public StockholdersEquityIncludingPortionAttributableToNoncontrollingInterest StockholdersEquityIncludingPortionAttributableToNoncontrollingInterest { get; set; }

    [JsonPropertyName("StockholdersEquityOther")]
    public StockholdersEquityOther StockholdersEquityOther { get; set; }

    [JsonPropertyName("StockIssuedDuringPeriodSharesAcquisitions")]
    public StockIssuedDuringPeriodSharesAcquisitions StockIssuedDuringPeriodSharesAcquisitions { get; set; }

    [JsonPropertyName("StockIssuedDuringPeriodSharesConversionOfConvertibleSecurities")]
    public StockIssuedDuringPeriodSharesConversionOfConvertibleSecurities StockIssuedDuringPeriodSharesConversionOfConvertibleSecurities { get; set; }

    [JsonPropertyName("StockIssuedDuringPeriodValueAcquisitions")]
    public StockIssuedDuringPeriodValueAcquisitions StockIssuedDuringPeriodValueAcquisitions { get; set; }

    [JsonPropertyName("StockIssuedDuringPeriodValueConversionOfConvertibleSecurities")]
    public StockIssuedDuringPeriodValueConversionOfConvertibleSecurities StockIssuedDuringPeriodValueConversionOfConvertibleSecurities { get; set; }

    [JsonPropertyName("StockRepurchasedAndRetiredDuringPeriodShares")]
    public StockRepurchasedAndRetiredDuringPeriodShares StockRepurchasedAndRetiredDuringPeriodShares { get; set; }

    [JsonPropertyName("StockRepurchasedAndRetiredDuringPeriodValue")]
    public StockRepurchasedAndRetiredDuringPeriodValue StockRepurchasedAndRetiredDuringPeriodValue { get; set; }

    [JsonPropertyName("StockRepurchasedDuringPeriodShares")]
    public StockRepurchasedDuringPeriodShares StockRepurchasedDuringPeriodShares { get; set; }

    [JsonPropertyName("StockRepurchasedDuringPeriodValue")]
    public StockRepurchasedDuringPeriodValue StockRepurchasedDuringPeriodValue { get; set; }

    [JsonPropertyName("StockRepurchaseProgramAuthorizedAmount")]
    public StockRepurchaseProgramAuthorizedAmount StockRepurchaseProgramAuthorizedAmount { get; set; }

    [JsonPropertyName("StockRepurchaseProgramRemainingAuthorizedRepurchaseAmount")]
    public StockRepurchaseProgramRemainingAuthorizedRepurchaseAmount StockRepurchaseProgramRemainingAuthorizedRepurchaseAmount { get; set; }

    [JsonPropertyName("SubleaseIncome")]
    public SubleaseIncome SubleaseIncome { get; set; }

    [JsonPropertyName("TaxEffectOfExtraordinaryItem")]
    public TaxEffectOfExtraordinaryItem TaxEffectOfExtraordinaryItem { get; set; }

    [JsonPropertyName("TaxesPayableCurrent")]
    public TaxesPayableCurrent TaxesPayableCurrent { get; set; }

    [JsonPropertyName("TreasuryStockAcquiredAverageCostPerShare")]
    public TreasuryStockAcquiredAverageCostPerShare TreasuryStockAcquiredAverageCostPerShare { get; set; }

    [JsonPropertyName("TreasuryStockShares")]
    public TreasuryStockShares TreasuryStockShares { get; set; }

    [JsonPropertyName("TreasuryStockValue")]
    public TreasuryStockValue TreasuryStockValue { get; set; }

    [JsonPropertyName("UnamortizedDebtIssuanceExpense")]
    public UnamortizedDebtIssuanceExpense UnamortizedDebtIssuanceExpense { get; set; }

    [JsonPropertyName("UnbilledReceivablesCurrent")]
    public UnbilledReceivablesCurrent UnbilledReceivablesCurrent { get; set; }

    [JsonPropertyName("UndistributedEarningsAllocatedToParticipatingSecurities")]
    public UndistributedEarningsAllocatedToParticipatingSecurities UndistributedEarningsAllocatedToParticipatingSecurities { get; set; }

    [JsonPropertyName("UndistributedEarningsLossAllocatedToParticipatingSecuritiesBasic")]
    public UndistributedEarningsLossAllocatedToParticipatingSecuritiesBasic UndistributedEarningsLossAllocatedToParticipatingSecuritiesBasic { get; set; }

    [JsonPropertyName("UnrecognizedTaxBenefits")]
    public UnrecognizedTaxBenefits UnrecognizedTaxBenefits { get; set; }

    [JsonPropertyName("UnrecognizedTaxBenefitsDecreasesResultingFromCurrentPeriodTaxPositions")]
    public UnrecognizedTaxBenefitsDecreasesResultingFromCurrentPeriodTaxPositions UnrecognizedTaxBenefitsDecreasesResultingFromCurrentPeriodTaxPositions { get; set; }

    [JsonPropertyName("UnrecognizedTaxBenefitsDecreasesResultingFromPriorPeriodTaxPositions")]
    public UnrecognizedTaxBenefitsDecreasesResultingFromPriorPeriodTaxPositions UnrecognizedTaxBenefitsDecreasesResultingFromPriorPeriodTaxPositions { get; set; }

    [JsonPropertyName("UnrecognizedTaxBenefitsDecreasesResultingFromSettlementsWithTaxingAuthorities")]
    public UnrecognizedTaxBenefitsDecreasesResultingFromSettlementsWithTaxingAuthorities UnrecognizedTaxBenefitsDecreasesResultingFromSettlementsWithTaxingAuthorities { get; set; }

    [JsonPropertyName("UnrecognizedTaxBenefitsIncreasesResultingFromAcquisition")]
    public UnrecognizedTaxBenefitsIncreasesResultingFromAcquisition UnrecognizedTaxBenefitsIncreasesResultingFromAcquisition { get; set; }

    [JsonPropertyName("UnrecognizedTaxBenefitsIncreasesResultingFromCurrentPeriodTaxPositions")]
    public UnrecognizedTaxBenefitsIncreasesResultingFromCurrentPeriodTaxPositions UnrecognizedTaxBenefitsIncreasesResultingFromCurrentPeriodTaxPositions { get; set; }

    [JsonPropertyName("UnrecognizedTaxBenefitsIncreasesResultingFromPriorPeriodTaxPositions")]
    public UnrecognizedTaxBenefitsIncreasesResultingFromPriorPeriodTaxPositions UnrecognizedTaxBenefitsIncreasesResultingFromPriorPeriodTaxPositions { get; set; }

    [JsonPropertyName("UnrecognizedTaxBenefitsInterestOnIncomeTaxesAccrued")]
    public UnrecognizedTaxBenefitsInterestOnIncomeTaxesAccrued UnrecognizedTaxBenefitsInterestOnIncomeTaxesAccrued { get; set; }

    [JsonPropertyName("UnrecognizedTaxBenefitsReductionsResultingFromLapseOfApplicableStatuteOfLimitations")]
    public UnrecognizedTaxBenefitsReductionsResultingFromLapseOfApplicableStatuteOfLimitations UnrecognizedTaxBenefitsReductionsResultingFromLapseOfApplicableStatuteOfLimitations { get; set; }

    [JsonPropertyName("UnrecognizedTaxBenefitsThatWouldImpactEffectiveTaxRate")]
    public UnrecognizedTaxBenefitsThatWouldImpactEffectiveTaxRate UnrecognizedTaxBenefitsThatWouldImpactEffectiveTaxRate { get; set; }

    [JsonPropertyName("ValuationAllowanceDeferredTaxAssetChangeInAmount")]
    public ValuationAllowanceDeferredTaxAssetChangeInAmount ValuationAllowanceDeferredTaxAssetChangeInAmount { get; set; }

    [JsonPropertyName("ValuationAllowancesAndReservesBalance")]
    public ValuationAllowancesAndReservesBalance ValuationAllowancesAndReservesBalance { get; set; }

    [JsonPropertyName("WeightedAverageNumberOfDilutedSharesOutstanding")]
    public WeightedAverageNumberOfDilutedSharesOutstanding WeightedAverageNumberOfDilutedSharesOutstanding { get; set; }

    [JsonPropertyName("WeightedAverageNumberOfSharesIssuedBasic")]
    public WeightedAverageNumberOfSharesIssuedBasic WeightedAverageNumberOfSharesIssuedBasic { get; set; }

    [JsonPropertyName("WeightedAverageNumberOfSharesOutstandingBasic")]
    public WeightedAverageNumberOfSharesOutstandingBasic WeightedAverageNumberOfSharesOutstandingBasic { get; set; }

    [JsonPropertyName("WeightedAverageNumberOfSharesRestrictedStock")]
    public WeightedAverageNumberOfSharesRestrictedStock WeightedAverageNumberOfSharesRestrictedStock { get; set; }

    [JsonPropertyName("DecreaseInUnrecognizedTaxBenefitsIsReasonablyPossible")]
    public DecreaseInUnrecognizedTaxBenefitsIsReasonablyPossible DecreaseInUnrecognizedTaxBenefitsIsReasonablyPossible { get; set; }

    [JsonPropertyName("DisposalGroupIncludingDiscontinuedOperationOtherCurrentAssets")]
    public DisposalGroupIncludingDiscontinuedOperationOtherCurrentAssets DisposalGroupIncludingDiscontinuedOperationOtherCurrentAssets { get; set; }

    [JsonPropertyName("DisposalGroupIncludingDiscontinuedOperationPropertyPlantAndEquipment")]
    public DisposalGroupIncludingDiscontinuedOperationPropertyPlantAndEquipment DisposalGroupIncludingDiscontinuedOperationPropertyPlantAndEquipment { get; set; }

    [JsonPropertyName("EquitySecuritiesWithoutReadilyDeterminableFairValueAmount")]
    public EquitySecuritiesWithoutReadilyDeterminableFairValueAmount EquitySecuritiesWithoutReadilyDeterminableFairValueAmount { get; set; }

    [JsonPropertyName("DistributionMadeToLimitedPartnerUnitDistribution")]
    public DistributionMadeToLimitedPartnerUnitDistribution DistributionMadeToLimitedPartnerUnitDistribution { get; set; }

    [JsonPropertyName("EquitySecuritiesFvNiUnrealizedLoss")]
    public EquitySecuritiesFvNiUnrealizedLoss EquitySecuritiesFvNiUnrealizedLoss { get; set; }

    [JsonPropertyName("GainLossOnInvestments")]
    public GainLossOnInvestments GainLossOnInvestments { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossForeignCurrencyTransactionAndTranslationReclassificationAdjustmentFromAOCIRealizedUponSaleOrLiquidationNetOfTax")]
    public OtherComprehensiveIncomeLossForeignCurrencyTransactionAndTranslationReclassificationAdjustmentFromAOCIRealizedUponSaleOrLiquidationNetOfTax OtherComprehensiveIncomeLossForeignCurrencyTransactionAndTranslationReclassificationAdjustmentFromAOCIRealizedUponSaleOrLiquidationNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeLossForeignCurrencyTransactionAndTranslationReclassificationAdjustmentFromAOCIRealizedUponSaleOrLiquidationTax")]
    public OtherComprehensiveIncomeLossForeignCurrencyTransactionAndTranslationReclassificationAdjustmentFromAOCIRealizedUponSaleOrLiquidationTax OtherComprehensiveIncomeLossForeignCurrencyTransactionAndTranslationReclassificationAdjustmentFromAOCIRealizedUponSaleOrLiquidationTax { get; set; }

    [JsonPropertyName("UnrealizedGainLossOnInvestments")]
    public UnrealizedGainLossOnInvestments UnrealizedGainLossOnInvestments { get; set; }

    [JsonPropertyName("AccruedIncomeTaxes")]
    public AccruedIncomeTaxes AccruedIncomeTaxes { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationDispositionOfBusiness")]
    public EffectiveIncomeTaxRateReconciliationDispositionOfBusiness EffectiveIncomeTaxRateReconciliationDispositionOfBusiness { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationGiltiAmount")]
    public EffectiveIncomeTaxRateReconciliationGiltiAmount EffectiveIncomeTaxRateReconciliationGiltiAmount { get; set; }

    [JsonPropertyName("EffectiveIncomeTaxRateReconciliationNondeductibleExpenseShareBasedCompensationCost")]
    public EffectiveIncomeTaxRateReconciliationNondeductibleExpenseShareBasedCompensationCost EffectiveIncomeTaxRateReconciliationNondeductibleExpenseShareBasedCompensationCost { get; set; }

    [JsonPropertyName("GovernmentAssistanceAmount")]
    public GovernmentAssistanceAmount GovernmentAssistanceAmount { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeForeignCurrencyTransactionAndTranslationGainLossArisingDuringPeriodNetOfTax")]
    public OtherComprehensiveIncomeForeignCurrencyTransactionAndTranslationGainLossArisingDuringPeriodNetOfTax OtherComprehensiveIncomeForeignCurrencyTransactionAndTranslationGainLossArisingDuringPeriodNetOfTax { get; set; }

    [JsonPropertyName("OtherComprehensiveIncomeForeignCurrencyTranslationGainLossArisingDuringPeriodTax")]
    public OtherComprehensiveIncomeForeignCurrencyTranslationGainLossArisingDuringPeriodTax OtherComprehensiveIncomeForeignCurrencyTranslationGainLossArisingDuringPeriodTax { get; set; }

    [JsonPropertyName("DeferredRevenueCurrent")]
    public DeferredRevenueCurrent DeferredRevenueCurrent { get; set; }

    [JsonPropertyName("ExtinguishmentOfDebtGainLossNetOfTax")]
    public ExtinguishmentOfDebtGainLossNetOfTax ExtinguishmentOfDebtGainLossNetOfTax { get; set; }

    [JsonPropertyName("NotesIssued1")]
    public NotesIssued1 NotesIssued1 { get; set; }

    [JsonPropertyName("NoncashContributionExpense")]
    public NoncashContributionExpense NoncashContributionExpense { get; set; }

    [JsonPropertyName("DebtInstrumentFaceAmount")]
    public DebtInstrumentFaceAmount DebtInstrumentFaceAmount { get; set; }

    [JsonPropertyName("DebtInstrumentIncreaseDecreaseForPeriodNet")]
    public DebtInstrumentIncreaseDecreaseForPeriodNet DebtInstrumentIncreaseDecreaseForPeriodNet { get; set; }

    [JsonPropertyName("LongtermDebtWeightedAverageInterestRate")]
    public LongtermDebtWeightedAverageInterestRate LongtermDebtWeightedAverageInterestRate { get; set; }

    [JsonPropertyName("EquityMethodInvestmentRealizedGainLossOnDisposal")]
    public EquityMethodInvestmentRealizedGainLossOnDisposal EquityMethodInvestmentRealizedGainLossOnDisposal { get; set; }

    [JsonPropertyName("InterestExpenseNonoperating")]
    public InterestExpenseNonoperating InterestExpenseNonoperating { get; set; }

    [JsonPropertyName("PaymentsForProceedsFromBusinessesAndInterestInAffiliates")]
    public PaymentsForProceedsFromBusinessesAndInterestInAffiliates PaymentsForProceedsFromBusinessesAndInterestInAffiliates { get; set; }

    [JsonPropertyName("ContractWithCustomerReceivableAfterAllowanceForCreditLoss")]
    public ContractWithCustomerReceivableAfterAllowanceForCreditLoss ContractWithCustomerReceivableAfterAllowanceForCreditLoss { get; set; }

    [JsonPropertyName("DefinedBenefitPlanContributionsByEmployer")]
    public DefinedBenefitPlanContributionsByEmployer DefinedBenefitPlanContributionsByEmployer { get; set; }

    [JsonPropertyName("ExtinguishmentOfDebtAmount")]
    public ExtinguishmentOfDebtAmount ExtinguishmentOfDebtAmount { get; set; }

    [JsonPropertyName("IncreaseDecreaseInDeferredRevenue")]
    public IncreaseDecreaseInDeferredRevenue IncreaseDecreaseInDeferredRevenue { get; set; }
}

