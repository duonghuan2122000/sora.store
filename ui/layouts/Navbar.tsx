import { useState } from "react";

const Navbar = () => {
	const [isShowNavbarMenu, setShowNavbarMenu] = useState(false);
	const [isShowMenu, setShowMenu] = useState(false);

	const toggleNavbarMenu = () => setShowNavbarMenu(!isShowNavbarMenu);
	const toggleMenu = () => setShowMenu(!isShowMenu);

	return (
		<nav className="relative flex items-center justify-start flex-wrap bg-gray-700 p-6">
			<div className="flex items-center lg:hidden">
				<button
					className="flex items-center px-3 py-2 border rounded text-gray-200 border-gray-400 hover:text-white hover:border-white"
					onClick={toggleNavbarMenu}
				>
					<i className="fas fa-bars"></i>
				</button>
			</div>
			<div className="flex items-center flex-shrink-0 ml-4 text-white mr-6 lg:ml-0">
				<div className="font-semibold text-xl tracking-tight">
					Store
				</div>
			</div>

			<div
				className={
					"w-full flex-grow lg:flex lg:items-center lg:w-auto lg:max-h-100 lg:opacity-100 transition-max-height " +
					(isShowNavbarMenu
						? "duration-500 ease-out transform max-h-100 opacity-100"
						: "duration-400 ease-in transform max-h-0 opacity-0")
				}
			>
				<div className="text-sm lg:flex-grow">
					<a
						href=""
						className="block px-4 py-2 mt-4 rounded lg:inline-block lg:mt-0 text-gray-200 hover:text-white hover:bg-gray-900 hover:border-white hover:rounded mr-4"
					>
						Home
					</a>
					<a
						href=""
						className="block px-4 py-2 mt-4 rounded lg:inline-block lg:mt-0 text-gray-200 hover:text-white hover:bg-gray-900 hover:border-white hover:rounded mr-4"
					>
						Home
					</a>
					<a
						href=""
						className="block px-4 py-2 mt-4 rounded lg:inline-block lg:mt-0 text-gray-200 hover:text-white hover:bg-gray-900 hover:border-white hover:rounded mr-4"
					>
						Home
					</a>
				</div>
			</div>
			<div className="absolute top-5 right-4 flex items-center">
				<div className="pr-2">
					<button
						type="button"
						className="flex text-sm px-1 rounded-full focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-offset-gray-800 focus:ring-white"
					>
						<span className="sr-only">Notifications</span>
						<i className="fas fa-bell text-2xl text-gray-200 hover:text-white"></i>
					</button>
				</div>
				<div>
					<button
						type="button"
						className="bg-gray-800 flex text-sm rounded-full focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-offset-gray-800 focus:ring-white"
						id="user-menu-button"
						aria-expanded="false"
						aria-haspopup="true"
						onClick={toggleMenu}
					>
						<span className="sr-only">Open user menu</span>
						<img
							className="h-8 w-8 rounded-full"
							src="https://images.unsplash.com/photo-1472099645785-5658abf4ff4e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=facearea&facepad=2&w=256&h=256&q=80"
							alt=""
						/>
					</button>

					<div
						className={
							"origin-top-right absolute right-0 mt-2 w-48 rounded-md shadow-lg py-1 bg-white ring-1 ring-black ring-opacity-5 focus:outline-none " +
							(isShowMenu
								? "transition ease-out duration-100 transform opacity-100 scale-100"
								: "transition ease-in duration-75 transform opacity-0 scale-95")
						}
						role="menu"
						aria-orientation="vertical"
						aria-labelledby="user-menu-button"
						tabIndex={-1}
					>
						{/* Active: "bg-gray-100", Not Active: "" */}
						<a
							href="#"
							className="block px-4 py-2 text-sm text-gray-700"
							role="menuitem"
							tabIndex={-1}
							id="user-menu-item-0"
						>
							Your Profile
						</a>
						<a
							href="#"
							className="block px-4 py-2 text-sm text-gray-700"
							role="menuitem"
							tabIndex={-1}
							id="user-menu-item-1"
						>
							Settings
						</a>
						<a
							href="#"
							className="block px-4 py-2 text-sm text-gray-700"
							role="menuitem"
							tabIndex={-1}
							id="user-menu-item-2"
						>
							Sign out
						</a>
					</div>
				</div>
			</div>
		</nav>
	);
};

export default Navbar;
