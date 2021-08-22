/**
 * Layout component dùng chung cho toàn ứng dụng
 * @author CreatedBy: dbhuan (22/08/2021)
 */

import { FC, ReactNode } from "react";
import Navbar from "./Navbar";

interface LayoutProps {
	children: ReactNode;
}

const Layout: FC<LayoutProps> = ({ children }: LayoutProps) => {
	return (
		<div>
			<Navbar />
			{children}
		</div>
	);
};

export default Layout;
