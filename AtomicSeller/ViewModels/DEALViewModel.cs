﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AtomicSeller.Helpers;
using AtomicSeller.Models;

namespace AtomicSeller.ViewModels
{

    public class DEALVM
    {
        public List<OrderVM> OrdersVM { get; set; }
        public List<DeliveryVM> DeliveriesVM{ get; set; }

        public DEALVM()
        {

        }

        public void DEALVMInit()
        {
            DeliveriesVM = new List<DeliveryVM>();
            DeliveriesVM.Add(new DeliveryVM());
             
            DeliveriesVM.First().Delivery = new DeliveryDM();

            OrdersVM = new List<OrderVM>();
            OrdersVM.Add(new OrderVM());
            OrdersVM.First().Order = new OrderDM();

            OrdersVM.First().OrderProducts = new List<OrderProductDM>();

        }
    }

    public class DeliveryVM
    {
        public DeliveryDM Delivery { get; set; }
        public List<DeliveryProductDM> DeliveryProducts { get; set; }

        public int ShippingCarrierType;
    }

    public class OrderVM
    {
        public OrderDM Order { get; set; }
        public List<OrderProductDM> OrderProducts { get; set; }
    }



    public partial class OrderProductDM
    {
        public int OrderProductID { get; set; }
        public string ItemID { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Price { get; set; }
        public string Tax { get; set; }
        public string Weight { get; set; }
        public Nullable<int> CN23CategoryID { get; set; }
        public string PriceExclTax { get; set; }
        public string Rate { get; set; }
        public string SubTotalPriceExclTax { get; set; }
        public string SubTotalTax { get; set; }
        public string EANCode { get; set; }
        public string Width { get; set; }
        public string Depth { get; set; }
        public string Length { get; set; }
        public string VariationID { get; set; }
        public string BundleID { get; set; }
        public string OrderID { get; set; }
    }

    public partial class OrderDM
    {
        public string OrderID { get; set; }
        public string OrderKey { get; set; }
        public string MerchantKey { get; set; }
        public string Store_Type { get; set; }
        public string Store_Name { get; set; }
        public System.DateTime Purchase_date { get; set; }
        public string Order_Status { get; set; }
        public string Shipping_last_name { get; set; }
        public string ShippingAddress_Name { get; set; }
        public string Address_Street1 { get; set; }
        public string Address_Street2 { get; set; }
        public string Address_Street3 { get; set; }
        public string postal_code { get; set; }
        public string ship_city { get; set; }
        public string ship_country { get; set; }
        public string Ship_phone_number { get; set; }
        public string Buyer_s_Phone { get; set; }
        public string Buyer_s_email { get; set; }
        public System.DateTime Payment_Date { get; set; }
        public string ShipmentTrackingNumber { get; set; }
        public string shipping_price { get; set; }
        public string Transaction_ID { get; set; }
        public string Ebay_Buyer_first_name { get; set; }
        public string EBAY_Buyer_UserLastName { get; set; }
        public string TransactionPrice { get; set; }
        public string ShippingCarrierUsed { get; set; }
        public string SalesRecordNumber { get; set; }
        public string FulfillmentChannel { get; set; }
        public string ship_service_level { get; set; }
        public Nullable<int> Order_Shipment_ID { get; set; }
        public string PaymentReferenceID { get; set; }
        public string Order_BuyerUserID { get; set; }
        public string Order_CustomerID { get; set; }
        public string CheckoutMessage { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string PaymentInfo { get; set; }
        public Nullable<System.DateTime> ModificationDate { get; set; }
        public string Currency { get; set; }
        public string OrderID_Ext { get; set; }
        public string OrderType { get; set; }
    }

    public partial class DeliveryDM
    {
        public int DeliveryID { get; set; }
        public Nullable<int> ShippingService { get; set; }
        public int NbOrderLines { get;set; }
        public string LowestProductLocation { get; set; }
        public System.DateTime ShippingDate { get; set; }
        public string ShippingPoint { get; set; }
        public string TrackingNumber { get; set; }
        public string ShipmentStatus { get; set; }
        public Nullable<int> ShippingWarehouse { get; set; }
        public string ParcelWeight { get; set; }
        public string Signed { get; set; }
        public string ParcelValue { get; set; }
        public string ParcelInsuranceValue { get; set; }
        public string LabelPath { get; set; }
        public System.DateTime DepositDate { get; set; }
        public string MailboxPicking { get; set; }
        public System.DateTime MailboxPickingDate { get; set; }
        public string recommendationLevel { get; set; }
        public string nonMachinable { get; set; }
        public string DeliveryAvisage { get; set; }
        public string DeliveryInstructions1 { get; set; }
        public string DeliveryInstructions2 { get; set; }
        public string DeliveryInstructions3 { get; set; }
        public string DeliveryRelayCountryCode { get; set; }
        public string DeliveryRelayNumber { get; set; }
        public string DeliveryReturn { get; set; }
        public string DeliveryMontage { get; set; }
        public string pickupLocationId { get; set; }
        public string RecipCompanyName { get; set; }
        public string RecipAdr0 { get; set; }
        public string RecipAdr1 { get; set; }
        public string RecipAdr2 { get; set; }
        public string RecipAdr3 { get; set; }
        public string RecipZip { get; set; }
        public string RecipCity { get; set; }
        public string RecipCountryISOCode { get; set; }
        public string RecipPhoneNumber { get; set; }
        public string RecipMobileNumber { get; set; }
        public string RecipFirstName { get; set; }
        public string RecipLastName { get; set; }
        public string RecipEmail { get; set; }
        public string RecipCompanyCode { get; set; }
        public string RecipCustomerCode { get; set; }
        public string RecipLanguageCode { get; set; }
        public string RecipCountryLib { get; set; }
        public string RecipDoorCode1 { get; set; }
        public string RecipDoorCode2 { get; set; }
        public string RecipIntercom { get; set; }
        public string RecipStage { get; set; }
        public string RecipInhabitationType { get; set; }
        public string RecipElevator { get; set; }
        public string SenderName { get; set; }
        public string SenderAddr1 { get; set; }
        public string SenderAddr2 { get; set; }
        public string SenderAddr3 { get; set; }
        public string SenderZip { get; set; }
        public string SenderCity { get; set; }
        public string SenderCountryLib { get; set; }
        public string SendercountryCode { get; set; }
        public string SenderDoorCode1 { get; set; }
        public string SenderDoorCode2 { get; set; }
        public string Senderintercom { get; set; }
        public string SenderRelayCountry { get; set; }
        public string SenderRelayNumber { get; set; }
        public string SenderCompanyName { get; set; }
        public string SenderPhoneNumber { get; set; }
        public string SenderEmail { get; set; }
        public string ProductCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorStatus { get; set; }
        public string ErrorCode { get; set; }
        public string ProductCategory { get; set; }
        public string senderParcelRef { get; set; }
        public string CustomsDeclarations { get; set; }
        public byte[] CustomsDeclarationsBase64 { get; set; }
        public string CustomDeclarationPath { get; set; }
        public string EDIStatus { get; set; }
        public string ParcelLenght { get; set; }
        public string ParcelHeight { get; set; }
        public string ParcelWidth { get; set; }
        public string ParcelSizeCode { get; set; }
        public string ParcelVolume { get; set; }
        public string WarehouseID { get; set; }
        public string InsurranceYN { get; set; }
        public string InsurranceCurrency { get; set; }
        public string ParcelValueCurrency { get; set; }
        public string LabelFileFormat { get; set; }
        public Nullable<int> LabelX { get; set; }
        public Nullable<int> LabelY { get; set; }
        public Nullable<int> ParcelShipmentSequence { get; set; }
        public string MerchantCode { get; set; }
        public string ShipmentIdentificationNumber { get; set; }
        public string TrackingInfo { get; set; }
        public string ShippingAmount { get; set; }
        public string Shipping_method_id { get; set; }
        public string Shipping_method_title { get; set; }
        public string parcelNumberPartner { get; set; }
        public string ShippingTax { get; set; }
        public string MerchantKey { get; set; }
        public string AdherentID { get; set; }
        public string SpecialServiceTypeCode { get; set; }
        public string OrderKey { get; set; }
    }

    public partial class ExcelDM
    {
        public string Date { get; set; }
        public string CustomerName { get; set; }
        public string OrderKey { get; set; }
        public string DeliveryCity { get; set; }
        public string ProductsName { get; set; }
        public string Size { get; set; }
        public string Quantity { get; set; }
        public string Location { get; set; }
    }
    public partial class DeliveryProductDM
    {
        public int DeliveryProductID { get; set; }
        public int DeliveryID { get; set; }
        public string ItemID { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Price { get; set; }
        public string Tax { get; set; }
        public string Weight { get; set; }
        public Nullable<int> CN23CategoryID { get; set; }
        public string PriceExclTax { get; set; }
        public string Rate { get; set; }
        public string SubTotalPriceExclTax { get; set; }
        public string SubTotalTax { get; set; }
        public string EANCode { get; set; }
        public string Width { get; set; }
        public string Depth { get; set; }
        public string Length { get; set; }
        public string VariationID { get; set; }
        public string BundleID { get; set; }
        public string HSCode { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Location { get; set; }
        public string Size { get; set; }
    }

}