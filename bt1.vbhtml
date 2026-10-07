

<!DOCTYPE html>

<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>TenSV_KtraFE</title>


    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css">

    <style>
        * {
            box-sizing: border-box;
            margin: 0;
            padding: 0;
            font-family: Arial, sans-serif;
        }
        language-select {
            display: flex;
            align-items: flex-end;
            gap:5px;
            cursor: pointer;
            padding: 8px 10px;
            border: 1px solid transparent;
        }
        language-icon {
            width: 22px;
            height:15px;
            object-fit:cover;
        }
        .lang-text{
            font-weight: bold;
            font-size: 14px;
            line-height: 15px;

        }
        language-select. fa-caret-down{
            font-size:12px;
            color: #a6a6a6;
            margin-bottom: 2px;
        }

        body {
            background-color: #eaeded;
        }
        .nav-account{
            display:flex;
            flex-direction:column;
            justify-content:center;
            cursor:pointer;
            padding:8px 10px;
            border:1px solid transparent;
            color:white;
        }
        .nav-account:hover
        {
            border: 1px solid white;
            border-radius: 2px;
        }
        .nav-line-1{
            font-size:12px;
            line-height:14px;
        }
        .nav-line-2 {
            font-size: 12px;
            font-weight: bold;
            line-height: 14px;
            display: flex;
            align-items: center;
            gap: 2px;
        }
        .nav-account .fa-caret-down{
            font-size: 12px;
            color: white;
            margin-top:2px;
        }


        header {
            background-color: #131921;
            display: flex;
            align-items: center;
            padding: 10px 20px;
            color: white;
            gap: 20px;
        }

        .logo {
            font-size: 24px;
            font-weight: bold;
            margin-right: 20px;
        }

        .search-bar {
            display: flex;
            flex-grow: 1;
            border-radius: 4px;
            overflow: hidden;
        }

            .search-bar select {
                padding: 10px;
                background: #f3f3f3;
                border: none;
                outline: none;
            }

            .search-bar input {
                flex-grow: 1;
                padding: 10px;
                border: none;
                outline: none;
            }

            .search-bar button {
                background-color: #febd69;
                border: none;
                padding: 10px 15px;
                cursor: pointer;
                color: #333;
            }

        .cart-icon {
            position: relative;
            font-size: 24px;
            display: flex;
            align-items: center;
            gap: 5px;
            cursor: pointer;
        }

        #cart-count {
            position: absolute;
            top: -10px;
            right: -10px;
            color: #f08804;
            font-weight: bold;
            font-size: 16px;
            background: #131921;
            border-radius: 50%;
            padding: 2px 6px;
        }

        /* Main Layout */
        .container {
            display: flex;
            max-width: 1200px;
            margin: 20px auto;
            gap: 20px;
            padding: 0 20px;
            align-items: flex-start;
        }

        /* Left Column - Cart Items */
        .cart-left {
            background-color: white;
            padding: 20px;
            flex: 3;
            border-radius: 4px;
        }

            .cart-left h2 {
                font-weight: normal;
                margin-bottom: 5px;
            }

        .price-label {
            text-align: right;
            color: #565959;
            font-size: 14px;
            margin-bottom: 5px;
        }

        .divider {
            border: 0;
            border-top: 1px solid #ddd;
            margin-bottom: 20px;
        }

        /* Cart Item Styling */
        .cart-item {
            display: flex;
            gap: 15px;
            padding-bottom: 20px;
            border-bottom: 1px solid #ddd;
            margin-bottom: 20px;
        }

            .cart-item input[type="checkbox"] {
                margin-top: 5px;
                cursor: pointer;
            }

        .item-img {
            width: 150px;
            height: 150px;
            object-fit: contain;
            background: #f8f8f8;
        }

        .item-details {
            flex-grow: 1;
        }

            .item-details h3 {
                font-size: 16px;
                color: #007185;
                font-weight: normal;
                margin-bottom: 5px;
                cursor: pointer;
            }

        .in-stock {
            color: #007600;
            font-size: 12px;
            margin-bottom: 5px;
        }

        .item-actions {
            display: flex;
            align-items: center;
            gap: 10px;
            margin-top: 10px;
            font-size: 13px;
        }

        .qty-select {
            padding: 5px;
            border-radius: 5px;
            background: #f0f2f2;
            border: 1px solid #d5d9d9;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
        }

        .item-actions a {
            color: #007185;
            text-decoration: none;
        }

            .item-actions a:hover {
                text-decoration: underline;
            }

        .separator {
            color: #ddd;
        }

        .item-price {
            font-size: 18px;
            font-weight: bold;
            width: 80px;
            text-align: right;
        }

        /* Subtotal Bottom */
        .subtotal-bottom {
            text-align: right;
            font-size: 18px;
            margin-top: 10px;
        }

        /* Right Column - Checkout */
        .cart-right {
            background-color: white;
            padding: 20px;
            flex: 1;
            border-radius: 4px;
        }

        .free-shipping {
            color: #007600;
            font-size: 12px;
            margin-bottom: 15px;
            display: flex;
            gap: 5px;
            align-items: flex-start;
        }

        .subtotal-box h3 {
            font-size: 18px;
            font-weight: normal;
            margin-bottom: 20px;
        }

        .checkout-btn {
            width: 100%;
            background-color: #ffd814;
            border: none;
            padding: 10px;
            border-radius: 20px;
            cursor: pointer;
            font-size: 14px;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
        }

            .checkout-btn:hover {
                background-color: #f7ca00;
            }
    </style>
</head>
<body>

    <header>
        @*<i class="fab fa-amazon fa-1,5x" style="color: rgb(255, 212, 59);></i>*@
        <div class="logo">amazon</div>
        
        <div class="search-bar">
            <select><option>All</option></select>
            <input type="text" placeholder="Search...">
            <button><i class="fas fa-search"></i></button>
        </div>
        <div class="language-select ">
            @*<img src="https://konhill.com/cdn/shop/files/8_03645f87-4cf5-4706-b19d-1366829ae73d.png?v=1773903185 t=Flag" alt="Flag" class="item-img">*@
            <span class="lang-text">EN </span>
            <i class="fas fa-caret-down "></i>
        </div>
        <div class="nav-account">
            <div class="nav-line-1">Hello,Cô Tú</div>
            <div class="nav-line-2">Account&Lists<i class="fas fa-caret-down"</div>
        </div>
        <div class="cart-icon">
            <i class="fas fa-shopping-cart fa-2x"></i>
            <span id="cart-count">0</span>
        </div>
        <span style="font-weight: bold; font-size: 14px;">Cart</span>
    </header>

    <div class="container">
        <!-- Giỏ hàng chính -->
        <div class="cart-left">
            <h2>Shopping Cart</h2>
            <div class="price-label">Price</div>
            <hr class="divider">

            <!-- Sản phẩm 1 -->
            <div class="cart-item" data-price="43.30">
                <input type="checkbox" checked>
                <img src="https://konhill.com/cdn/shop/files/8_03645f87-4cf5-4706-b19d-1366829ae73d.png?v=1773903185 t=Shoes" alt="Shoes" class="item-img">
                <div class="item-details">
                    <h3>Women's Slip on Walking Shoes Tennis Sneakers</h3>
                    <div class="in-stock">In Stock</div>
                    <div class="item-actions">
                        <select class="qty-select">
                            <option value="1">Qty: 1</option>
                            <option value="2">Qty: 2</option>
                            <option value="3">Qty: 3</option>
                        </select>
                        <span class="separator">|</span>
                        <a href="#">Delete</a>
                        <span class="separator">|</span>
                        <a href="#">Save for later</a>
                    </div>
                </div>
                <div class="item-price">$<span class="item-total">43.30</span></div>
            </div>

            <!-- Sản phẩm 2 -->
            <div class="cart-item" data-price="115.50">
                <input type="checkbox" checked>
                <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRAyJ7rezxeVWIJubbCXKWKYyoinWBdcjidgTC9as88vA&s" alt="Cap" class="item-img">
                <div class="item-details">
                    <h3>Baseball Cap Unisex Cotton</h3>
                    <div class="in-stock">In Stock</div>
                    <div class="item-actions">
                        <select class="qty-select">
                            <option value="1">Qty: 1</option>
                            <option value="2">Qty: 2</option>
                            <option value="3">Qty: 3</option>
                        </select>
                        <span class="separator">|</span>
                        <a href="#">Delete</a>
                        <span class="separator">|</span>
                        <a href="#">Save for later</a>
                    </div>
                </div>
                <div class="item-price">$<span class="item-total">115.50</span></div>
            </div>

            <div class="subtotal-bottom">
                Subtotal (<span class="total-items-text">0</span> items): <strong>$<span class="grand-total-text">0.00</span></strong>
            </div>
        </div>

        <!-- Khung Thanh Toán -->
        <div class="cart-right">
            <div class="subtotal-box">
                <div class="free-shipping">
                    <i class="fas fa-check-circle fa-lg"></i>
                    <span>Your order qualifies for FREE Shipping.<br><span style="color: #565959;">Choose this option at checkout.</span></span>
                </div>
                <h3>Subtotal (<span class="total-items-text">0</span> items): <strong>$<span class="grand-total-text">0.00</span></strong></h3>
                <button class="checkout-btn">Proceed to checkout</button>
            </div>
        </div>
    </div>

    <!-- JavaScript xử lý logic theo yêu cầu -->
    <script>
        document.addEventListener("DOMContentLoaded", function () {
            const qtySelects = document.querySelectorAll('.qty-select');

            // Hàm tính toán giỏ hàng (Yêu cầu JS)
            function calculateCart() {
                let totalQuantity = 0;
                let grandTotal = 0;

                const items = document.querySelectorAll('.cart-item');

                items.forEach(item => {
                    const price = parseFloat(item.getAttribute('data-price'));
                    const quantity = parseInt(item.querySelector('.qty-select').value);

                    // 1. Tính giá trị của một mặt hàng khi thay đổi số lượng
                    const itemTotalPrice = price * quantity;
                    item.querySelector('.item-total').textContent = itemTotalPrice.toFixed(2);

                    totalQuantity += quantity;
                    grandTotal += itemTotalPrice;
                });

                // 2. Tổng số lượng mặt hàng hiển thị lên cạnh biểu tượng giỏ hàng
                document.getElementById('cart-count').textContent = totalQuantity;

                // Cập nhật text hiển thị (Số lượng items và Tổng tiền)
                document.querySelectorAll('.total-items-text').forEach(el => {
                    el.textContent = totalQuantity;
                });
                document.querySelectorAll('.grand-total-text').forEach(el => {
                    el.textContent = grandTotal.toFixed(2);
                });
            }

            // Gắn sự kiện "change" để khi người dùng tăng giảm số lượng thì gọi lại hàm tính
            qtySelects.forEach(select => {
                select.addEventListener('change', calculateCart);
            });

            // Chạy tính toán lần đầu khi load trang
            calculateCart();
        });
    </script>
</body>
</html> 