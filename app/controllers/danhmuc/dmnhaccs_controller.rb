module Danhmuc
  class DmnhaccsController < PageController
    helper_method :sort_column, :sort_direction
    respond_to :html, :js

    def index
      @dmnhaccs = Dmnhacc.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
      #@dmnuocsxes=Dmnuocsx.all#.paginate(:page => params[:page], :per_page => 12)
    end

    def show
      @dmnhacc = Dmnhacc.find(params[:id])
    end

    def edit
      @dmnhacc = Dmnhacc.find(params[:id])
    end

    def update
      @dmnhaccs = Dmnhacc.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)

      @dmnhacc = Dmnhacc.find(params[:id])
      @dmnhacc.update_attributes(dmnhacc_params)
    end

    def new
      @dmnhacc = Dmnhacc.new
    end

    def create
      @dmnhaccs = Dmnhacc.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
      @dmnhacc =Dmnhacc.create(dmnhacc_params)
    end

    def delete
      @dmnhacc = Dmnhacc.find(params[:dmnhacc_id])
    end

    def destroy
      @dmnhaccs = Dmnhacc.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
      @dmnhacc = Dmnhacc.find(params[:id])
      @dmnhacc.destroy
    end

    private
    def dmnhacc_params
      params.require(:dmnhacc).permit(:stt, :ma, :ten, :diachi, :dt, :masothue, :sotk, :daidien, :dmnhomnhacc_id)
    end

    def sort_column
      Dmnhacc.column_names.include?(params[:sort]) ? params[:sort] : "ten"
    end

    def sort_direction
      %w[asc desc].include?(params[:direction]) ? params[:direction] : "asc"
    end
  end

end